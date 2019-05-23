using FontysMadeSteam.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace FontysMadeSteam.DAL.Context
{
    public class GameSQLContext
    {
        private MySqlConnection _connection;
        public GameSQLContext()
        {
            _connection = new MySqlConnection
            {
                ConnectionString = string.Format("SERVER=studmysql01.fhict.local; UID = dbi397713; DATABASE = dbi397713; PASSWORD = s21Database;")
            };
        }
        public IEnumerable<WpPost> GetWpPosts()
        {
            List<WpPost> ListOfPosts = new List<WpPost>();
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT ID, post_title, post_content FROM wp_posts", _connection);
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    WpPost tempPost = new WpPost();

                    if (!dr.IsDBNull(0))
                    {
                        tempPost.Id = dr.GetInt32(0);
                    }
                    if (!dr.IsDBNull(1))
                    {
                        tempPost.Title = dr.GetString(1);
                    }
                    if (!dr.IsDBNull(2))
                    {
                        tempPost.Content = dr.GetString(2);
                    }
                    ListOfPosts.Add(tempPost);
                }
            }
            _connection.Close();
          /*  foreach (WpPost post in ListOfPosts)
            {
                IEnumerable<string> tagList = new TagSqlContext().GetTags(post.Id);
                post.Tags.AddRange(tagList);
                IEnumerable<string> CategoryList = new TagSqlContext().GetCategory(post.Id);
                post.Categories.AddRange(CategoryList);
            } */


            return ListOfPosts;
        }

        public WpPost GetWpPostById(int id)
        {
            WpPost tempPost = new WpPost();
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT ID, post_title, post_content FROM wp_posts WHERE ID=?id", _connection);
            cmd.Parameters.Add(new MySqlParameter("id", id));
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    if (!dr.IsDBNull(0))
                    {
                        tempPost.Id = dr.GetInt32(0);
                    }
                    if (!dr.IsDBNull(1))
                    {
                        tempPost.Title = dr.GetString(1);
                    }
                    if (!dr.IsDBNull(2))
                    {
                        tempPost.Content = dr.GetString(2);
                    }

                }
            }
            _connection.Close();
            /* IEnumerable<string> taglist = new TagSqlContext().GetTags(tempPost.Id);
            IEnumerable<string> CategoryList = new TagSqlContext().GetCategory(tempPost.Id);
            if(taglist != null)
            {
                foreach (string tag in taglist)
                {
                    tempPost.Tags.Add(tag);
                }
            }
            if(CategoryList != null)
            {
                foreach (string category in CategoryList)
                {
                    tempPost.Categories.Add(category);
                }
            }
            */
          
            return tempPost;
        }

        public void AddWpPost(WpPost post)
        {
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand("Insert Into wp_posts(ID, post_title, post_content) VALUES(?id, ?title, ?content);", _connection);
            cmd.Parameters.Add(new MySqlParameter("id", post.Id));
            cmd.Parameters.Add(new MySqlParameter("title", post.Title));
            cmd.Parameters.Add(new MySqlParameter("content", post.Content));

            cmd.ExecuteNonQuery();
            _connection.Close();
        }

        public IEnumerable<WpPost> GetPostByCategoryOrTag(string category)
        {
            List<WpPost> tempList = new List<WpPost>();
           
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT wp_posts.ID , wp_posts.post_title , wp_posts.post_content From wp_posts Inner Join wp_term_relationships on wp_posts.ID = wp_term_relationships.object_id inner JOIN wp_term_taxonomy on wp_term_relationships.term_taxonomy_id = wp_term_taxonomy.term_taxonomy_id INNER JOIN wp_terms on wp_terms.term_id = wp_term_taxonomy.term_id where wp_terms.name like ?search", _connection);
            cmd.Parameters.Add(new MySqlParameter("search", "%" + category + "%"));
            using(MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    WpPost tempPost = new WpPost();
                    while (dr.Read())
                    {
                        if (!dr.IsDBNull(0))
                        {
                            tempPost.Id = dr.GetInt32(0);
                        }
                        if (!dr.IsDBNull(1))
                        {
                            tempPost.Title = dr.GetString(1);
                        }
                        if (!dr.IsDBNull(2))
                        {
                            tempPost.Content = dr.GetString(2);
                        }
                    }
                    tempList.Add(tempPost);
                }
            }
            _connection.Close();
          /*  foreach(WpPost post in tempList)
            {
                IEnumerable<string> taglist = new TagSqlContext().GetTags(post.Id);
                post.Tags.AddRange(taglist);
                IEnumerable<string> categoryList = new TagSqlContext().GetCategory(post.Id);
                post.Tags.AddRange(categoryList);
            } */
            return tempList;
        }
        
    }
}
