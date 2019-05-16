using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace FontysMadeSteam.DAL.Context
{
    public class TagSqlContext
    {
        private readonly MySqlConnection _connection;
        public TagSqlContext()
        {
            _connection = new MySqlConnection
            {
                ConnectionString = "studmysql01.fhict.local; Uid = dbi397713; Database = dbi397713; Pwd = S21Database;"
            };
        }
        public List<string> GetTagNames()
        {
            List<string> ListOfTags = new List<string>();
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand("", _connection);
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                string tag;
                while (dr.Read())
                {
                    tag = dr.GetString(0);
                    ListOfTags.Add(tag);
                }
            }
            _connection.Close();
            return ListOfTags;
        }
    }
}
