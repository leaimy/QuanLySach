using QuanLySach.App.models;
using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DAO
{
    internal class DataProvider
    {
        private static DataProvider _instance;
        private string connectionSTR;

        private ChiNhanhEnum branch;
        private string loginName;
        private string password;

        private int who;
        private DataProvider() { }

        public static DataProvider Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataProvider();
                }
                return _instance;
            }
        }

        public void SetRemoteAccount(ChiNhanhEnum branch)
        {
            this.branch = branch;
            loginName = "remoteLogin";
            password = "remoteLogin";

            SetConnectionString();
        }

        public void SetDBAccount(ChiNhanhEnum branch, string loginName, string password)
        {
            this.branch = branch;
            this.loginName = loginName;
            this.password = password;

            SetConnectionString();
        }

        private void SetConnectionString()
        {
            if (who == 1)
            {
                connectionSTR = $"Data Source=DALATHUB\\QLSACH1;Initial Catalog=QLSACH;User id={loginName}; password={password}";

                if (branch == ChiNhanhEnum.CN_2)
                    connectionSTR = $"Data Source=DALATHUB\\QLSACH2;Initial Catalog=QLSACH;User id={loginName}; password={password}";
            }

            else if (who == 2)
            {
                connectionSTR = $"Data Source=DESKTOP-C27NP9T\\QLSACH1;Initial Catalog=QLSACH;User id={loginName}; password={password}";

                if (branch == ChiNhanhEnum.CN_2)
                    connectionSTR = $"Data Source=DESKTOP-C27NP9T\\QLSACH2;Initial Catalog=QLSACH;User id={loginName}; password={password}";
            }

            else if (who == 3)
            {
                connectionSTR = $"Data Source=DALATHUB\\QLSACH1;Initial Catalog=QLSACH;User id={loginName}; password={password}";

                if (branch == ChiNhanhEnum.CN_2)
                    connectionSTR = $"Data Source=DALATHUB\\QLSACH2;Initial Catalog=QLSACH;User id={loginName}; password={password}";
            }
        }

        public void InitConnectionString(ChiNhanhEnum branch, string loginName, string password, int who)
        {
            this.branch = branch;
            this.loginName = loginName;
            this.password = password;
            this.who = who;

            SetConnectionString();
        }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listParams = query.Split(' ');
                    int i = 0;

                    foreach (string item in listParams)
                    {
                        if (item.StartsWith("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i += 1;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int numRowEffected = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listParams = query.Split(' ');
                    int i = 0;

                    foreach (string item in listParams)
                    {
                        if (item.StartsWith("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i += 1;
                        }
                    }
                }

                numRowEffected = command.ExecuteNonQuery();

                connection.Close();
            }

            return numRowEffected;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = null;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listParams = query.Split(' ');
                    int i = 0;

                    foreach (string item in listParams)
                    {
                        if (item.StartsWith("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i += 1;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }

    }
}
