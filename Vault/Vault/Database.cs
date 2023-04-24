using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Net;
using System.Xml;
using System.Collections;

public class Database
{
    private static MySqlConnection _connection = null;
    
    public static string Username { get; set; }
    public static string Password { get; set; }

    /*
     * Try connect to MySQL Database
     * Initiates the connection at first, sets the static connection Variable
     */
    public static void TryConnect()
    {
        if (_connection == null)
        {
            try
            {
                string connectionString = "Server=sql7.freemysqlhosting.net;Database=sql7614096;Uid=" + Username + ";Pwd=" + Password + ";";
                Console.WriteLine("Attempted query: " + connectionString);
                _connection = new MySqlConnection(connectionString);
                _connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }

    /*
     * Get Connection
     * Should be initialized with TryConnect()
     */
    public static MySqlConnection Connection
    {
        get
        {
            if (_connection == null)
            {
                TryConnect();
                if (!Database.IsValid) return null;
            }

            return _connection;
        }
    }

    /*
     * Check connection validity
     * NOTE: Execute every time when connecting to the database
     */
    public static bool IsValid
    {
        get { return _connection != null; }
    }

    /* 
     * ===========================================
     * Currencies table functions
     * ===========================================
     */

    public static void Currencies_UpdateDatabase()
    {
        const string fileUrl = "https://nbs.sk/export/sk/exchange-rate/latest/xml";
        string fileSave = Path.GetTempPath() + "/exchangerates.xml";

        WebClient client = new WebClient();
        client.DownloadFile(fileUrl, fileSave);

        using (XmlReader reader = XmlReader.Create(fileSave))
        {
            // Skip past any whitespace
            reader.MoveToContent();

            // Read through the XML file
            while (reader.Read())
            {
                // Check if this is an element
                if (reader.NodeType == XmlNodeType.Element)
                {
                    // Check if this is a Cube element
                    if (reader.Name == "Cube")
                    {
                        // Check if this is a Cube element with a time attribute
                        if (reader.HasAttributes && reader.GetAttribute("time") != null)
                        {
                            // Get the time attribute value
                            string time = reader.GetAttribute("time");
                            //lbox_ExchangeRates.Items.Add("Time: " + time);
                        }
                        // Check if this is a Cube element with currency and rate attributes
                        else if (reader.HasAttributes && reader.GetAttribute("currency") != null && reader.GetAttribute("rate") != null)
                        {
                            // Get the currency and rate attribute values
                            string currency = reader.GetAttribute("currency");
                            string rate = reader.GetAttribute("rate");
                            Database.Currencies_UpdateTableCurrency(currency, rate);

                        }
                    }
                }
            }
        }

        File.Delete(fileSave);
    }

    public static void Currencies_UpdateTableCurrency(string currency, string rate)
    {
        // Check database connection validity
        if (!Database.IsValid) return;

        string query;

        // Get elements count
        query = "SELECT COUNT(DISTINCT currency_name) FROM Currencies";
        int count = Convert.ToInt32(new MySqlCommand(query, Database.Connection).ExecuteScalar());

        // Get if currency exists
        query = "SELECT COUNT(*) FROM Currencies WHERE currency_name = @currencyName";
        MySqlCommand cmd = new MySqlCommand(query, Database.Connection);
        cmd.Parameters.AddWithValue("@currencyName", currency);

        // If currency exists, update exhange rate
        // If not, insert new values
        if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
        {
            // Update the currency rate
            query = "UPDATE Currencies SET exchange_rate = @currencyRate WHERE currency_name = @currencyName";
            cmd = new MySqlCommand(query, Database.Connection);
            cmd.Parameters.AddWithValue("@currencyRate", rate);
            cmd.Parameters.AddWithValue("@currencyName", currency);
            cmd.ExecuteNonQuery();
        }
        else
        {
            // Insert a new currency
            query = "INSERT INTO Currencies (currency_id, currency_name, exchange_rate) VALUES (" + (count + 1) + ", @currencyName, @currencyRate)";
            cmd = new MySqlCommand(query, Database.Connection);
            cmd.Parameters.AddWithValue("@currencyName", currency);
            cmd.Parameters.AddWithValue("@currencyRate", rate);
            cmd.ExecuteNonQuery();
        }
    }

    /*
     * Get Currency rate from Currency database
     * Return 0 if invalid
     */
    public static double GetCurrencyRate(string currencyName)
    {
        // Check connection
        if (!Database.IsValid) return 0.0f;

        // Get if currency exists
        MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM Currencies WHERE currency_name = @currencyName", Database.Connection);
        cmd.Parameters.AddWithValue("@currencyName", currencyName);

        if (Convert.ToInt32(cmd.ExecuteScalar()) <= 0) return 0.0f;

        cmd = new MySqlCommand("SELECT exchange_rate FROM Currencies WHERE currency_name = @currencyName", Database.Connection);
        cmd.Parameters.AddWithValue("@currencyName", currencyName);

        return Convert.ToDouble(cmd.ExecuteScalar());

    }

    public static bool LogTransaction(string currencyName, double exchangeAmount, string customerID)
    {
        // Check connection
        if (!Database.IsValid) return false;

        MySqlCommand cmd;

        cmd = new MySqlCommand("SELECT COUNT(*) FROM Customers WHERE passport_number = @passportNumber", Database.Connection);
        cmd.Parameters.AddWithValue("@passportNumber", customerID);
        if (Convert.ToUInt32(cmd.ExecuteScalar()) <= 0) return false;

        // Obtain Customer ID
        UInt32 customerId;

        cmd = new MySqlCommand("SELECT customer_id FROM Customers WHERE passport_number = @customerName", Database.Connection);
        cmd.Parameters.AddWithValue("@customerName", customerID);
        customerId = Convert.ToUInt32(cmd.ExecuteScalar());

        // Obtain Currency ID
        UInt32 currencyId;

        cmd = new MySqlCommand("SELECT currency_id FROM Currencies WHERE currency_name = @currencyName", Database.Connection);
        cmd.Parameters.AddWithValue("@currencyName", currencyName);
        currencyId = Convert.ToUInt32(cmd.ExecuteScalar());

        // Get elements count
        cmd = new MySqlCommand("SELECT COUNT(DISTINCT transaction_id) FROM Transactions", Database.Connection);
        UInt32 count = Convert.ToUInt32(cmd.ExecuteScalar());

        // Save Timestamp
        string timestamp = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");

        cmd = new MySqlCommand("INSERT INTO Transactions (transaction_id, customer_id, currency_id, transaction_date, amount) VALUES (@transaction_id, @customer_id, @currency_id, @transaction_date, @amount)", Database.Connection);
        cmd.Parameters.AddWithValue("@transaction_id", count + 1);
        cmd.Parameters.AddWithValue("@customer_id", customerId);
        cmd.Parameters.AddWithValue("@currency_id", currencyId);
        cmd.Parameters.AddWithValue("@transaction_date", timestamp);
        cmd.Parameters.AddWithValue("@amount", exchangeAmount);
        cmd.ExecuteNonQuery();

        return true;
    }     


}