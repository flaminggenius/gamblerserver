﻿using System;
using MySql.Data.MySqlClient;

namespace GamblerServerCrossPlatform
{
    public class MySQL {
        public static MySQLSettings mySQLSettings;

        public static MySqlConnection GetConn() {
            return new MySqlConnection(CreateConnectionString());
        }

        public static void OpenConnection(MySqlConnection conn) {
            conn.Open();
            Console.WriteLine("Connection to MySQL Server has been opened");
        }

        public static void CloseConnection(MySqlConnection conn) {
            conn.Close();
            Console.WriteLine("Connection to MySQL Server has been terminated");
        }

        private static string CreateConnectionString() {
            var db = mySQLSettings;
            string connectionString = "Server=" + db.server + ";" +
                "Database=" + db.database + ";" +
                "User Id=" + db.user + ";" +
                "Password=" + db.password + ";";
            return connectionString;
        }
    }

    public struct MySQLSettings {
        public string server;
        public string database;
        public string user;
        public string password;
    }
}
