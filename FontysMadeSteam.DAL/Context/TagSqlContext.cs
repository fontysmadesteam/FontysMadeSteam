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
                ConnectionString = string.Format("SERVER=studmysql01.fhict.local; UID = dbi397713; DATABASE = dbi397713; PASSWORD = s21Database;")
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

        public IEnumerable<string> GetCategory(int id)
        {
            List<string> ListOfTags = new List<string>();
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand("Select wp_terms.name From wp_terms inner join wp_term_taxonomy  on wp_terms.term_id = wp_term_taxonomy.term_id inner join wp_term_relationships on wp_term_relationships.term_taxonomy_id = wp_term_taxonomy.term_taxonomy_id where wp_term_taxonomy.taxonomy = 'category' AND wp_term_relationships.object_id = ?id", _connection);
            cmd.Parameters.Add(new MySqlParameter("id", id));
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    ListOfTags.Add(dr.GetString(0));
                }
            }
            _connection.Close();
            if(ListOfTags.Count == 0)
            {
                return null;
            }
            return ListOfTags;
        }

        public IEnumerable<string> GetTags(int id)
        {

            List<string> ListOfTags = new List<string>();
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand("Select wp_terms.name From wp_terms inner join wp_term_taxonomy  on wp_terms.term_id = wp_term_taxonomy.term_id inner join wp_term_relationships on wp_term_relationships.term_taxonomy_id = wp_term_taxonomy.term_taxonomy_id where wp_term_taxonomy.taxonomy = 'post_tag' AND wp_term_relationships.object_id = ?id", _connection);
            cmd.Parameters.Add(new MySqlParameter("id", id));
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    ListOfTags.Add(dr.GetString(0));
                }
            }
            
            _connection.Close();
            if(ListOfTags.Count == 0)
            {
                return null;
            }
            return ListOfTags;

        }
    }
}
