using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalProj
{
    class funcs
    {
        public static string tryLogin(string ID, string Pw)
        {
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            string output = "";
            using (var cn = new SqlConnection(cns))
            {
                cn.Open();
                string tmp = $"SELECT Pw, AccType FROM Account c WHERE c.Phone = '{ID}';";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    output = dataReader.GetValue(0).ToString();
                    Form1.AccType = dataReader.GetValue(1).ToString();
                }
                if (output == Pw)
                    output = ID;
                else
                    output = "flag";
                dataReader.Close(); // close after reading
                cn.Close();
            }
            return output;
            // return flag if login fails, return the same phone number if success
        }

        public static string getTier(string Phone)
        {
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            string output = "";
            using (var cn = new SqlConnection(cns))
            {
                cn.Open();
                string tmp = $"SELECT TOP 1 Tier FROM Points p join CustomerTier c on p.Point >= c.Milestone WHERE p.Phone = '{Phone}' ORDER BY Milestone DESC;";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    output = dataReader.GetValue(0).ToString();
                }
                dataReader.Close(); // close after reading
                cn.Close();
            }
            return output;
        }

        public static string getCusName(string Phone, string sel) // Get first name
        {
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            string output = "";
            using (var cn = new SqlConnection(cns))
            {
                cn.Open();
                string tmp = $"SELECT {sel} FROM Customers WHERE Phone = '{Phone}';";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    output = dataReader.GetValue(0).ToString();
                }
                dataReader.Close(); // close after reading
                cn.Close();
            }
            return output;
        }

        public static string getEmpName(string Phone, string sel) // Get first name
        {
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            string output = "";
            using (var cn = new SqlConnection(cns))
            {
                cn.Open();
                string tmp = $"SELECT {sel} FROM Employees WHERE Phone = '{Phone}';";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    output = dataReader.GetValue(0).ToString();
                }
                dataReader.Close(); // close after reading
                cn.Close();
            }
            return output;
        }

        public static string getPos(string Phone) // Get first name
        {
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            string output = "";
            using (var cn = new SqlConnection(cns))
            {
                cn.Open();
                string tmp = $"SELECT Pos FROM Employees WHERE Phone = '{Phone}';";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    output = dataReader.GetValue(0).ToString();
                }
                dataReader.Close(); // close after reading
                cn.Close();
            }
            return output;
        }


        public static void updateCusNames(string Fname, string Lname, string Phone)
        {
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                cn.Open();
                string tmp = $"UPDATE Customers SET Fname = '{Fname}', Lname = '{Lname}' WHERE Phone = '{Phone}';";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteNonQuery();
                cn.Close();
            }
        }

        public static void updateEmpNames(string Fname, string Lname, string Phone)
        {
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                cn.Open();
                string tmp = $"UPDATE Employees SET Fname = '{Fname}', Lname = '{Lname}' WHERE Phone = '{Phone}';";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteNonQuery();
                cn.Close();
            }
        }

        public static void updatePass(string Password, string Phone)
        {
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                cn.Open();
                string tmp = $"UPDATE Account SET Pw = '{Password}' WHERE Phone = '{Phone}';";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteNonQuery();
                cn.Close();
            }
        }

        public static void newAccount(string Phone, string Pass, string fName, string lName)
        {
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                cn.Open();
                string tmp = $"INSERT INTO Account VALUES ('{Phone}', '{Pass}','c');INSERT INTO Customers VALUES ('{Phone}', '{fName}', '{lName}');INSERT INTO Points VALUES ('{Phone}', '0');";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteNonQuery();
                cn.Close();
            }
        }

        public static bool verifyPhone(string Phone)
        {
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                cn.Open();
                string tmp = "SELECT Phone FROM Account;";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader.GetValue(0).ToString() == Phone)
                        return false;
                }
                dataReader.Close(); // close after reading
                cn.Close();
            }
            return true;
        }


        public static void addOrder(string Phone, int OrderNum, int total)
        {
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                cn.Open();
                string tmp = $"INSERT INTO Orders VALUES ('{OrderNum}', '{Phone}', '{total}', CURRENT_TIMESTAMP);UPDATE Points SET Point = '{getPoint(Phone) + total}' WHERE Phone = '{Phone}';";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteNonQuery();
                cn.Close();
            }
        }
        public static void addOrderDetail(int OrderNum, string SKU, int Quant)
        {
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                cn.Open();
                string tmp = $"INSERT INTO OrderDetail VALUES ('{OrderNum}','{SKU}', '{Quant}');";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteNonQuery();
                cn.Close();
            }
        }

        public static int getPoint(string Phone)
        {
            int output = 0;
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                cn.Open();
                string tmp = $"SELECT Point FROM Points WHERE Phone = '{Phone}';";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    output = int.Parse(dataReader.GetValue(0).ToString());
                }
                dataReader.Close(); // close after reading
                cn.Close();
            }
            return output;
        }

        public static string getPrice (string Item)
        {
            string output = "";
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                cn.Open();
                string tmp = $"SELECT Price FROM Menu WHERE ItemName = '{Item}';";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    output = dataReader.GetValue(0).ToString();
                }
                dataReader.Close(); // close after reading
                cn.Close();
            }
            return output;
        }

        public static string getSKU(string Item)
        {
            string output = "";
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                cn.Open();
                string tmp = $"SELECT SKU FROM Menu WHERE ItemName = '{Item}';";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    output = dataReader.GetValue(0).ToString();
                }
                dataReader.Close(); // close after reading
                cn.Close();
            }
            return output;
        }




        public static int getLastOrder()
        {
            int output = 0;
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                cn.Open();
                string tmp = "SELECT TOP 1 OrderNum FROM Orders ORDER BY OrderNum DESC;";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    output = int.Parse(dataReader.GetValue(0).ToString());
                }
                dataReader.Close(); // close after reading
                cn.Close();
            }
            return output;
        }
    }
}
