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
        public IEnumerable<string> GetTagNames()
        {
            List<string> ListOfTags = new List<string>();
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand("Select wp_terms.name From wp_terms inner join wp_term_taxonomy on wp_terms.term_id = wp_term_taxonomy.term_id where wp_term_taxonomy.taxonomy = 'post_tag'", _connection);
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    ListOfTags.Add(dr.GetString(0));
                }
            }
            _connection.Close();
            return ListOfTags;
        }
        public IEnumerable<string> GetCategorieNames()
        {
            List<string> ListOfCategories = new List<string>();
            _connection.Open();
            //Where wp_term_taxonomy.taxonomy = "category"
            MySqlCommand cmd = new MySqlCommand("Select wp_terms.name From wp_terms inner join wp_term_taxonomy on wp_terms.term_id = wp_term_taxonomy.term_id where wp_term_taxonomy.taxonomy = 'category'", _connection);
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    ListOfCategories.Add(dr.GetString(0));
                }
            }
            _connection.Close();
            return ListOfCategories;
        }
    }
}
