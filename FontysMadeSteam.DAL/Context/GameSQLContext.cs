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
                ConnectionString = "studmysql01.fhict.local; Uid = dbi397713; Database = dbi397713; Pwd = S21Database;"
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
            foreach (WpPost post in ListOfPosts)
            {
                IEnumerable<string> tagList = new TagSqlContext().GetTags(post.Id);
                post.Tags.AddRange(tagList);
                IEnumerable<string> CategoryList = new TagSqlContext().GetCategory(post.Id);
                post.Categories.AddRange(CategoryList);
            }

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
            IEnumerable<string> taglist = new TagSqlContext().GetTags(tempPost.Id);
            IEnumerable<string> CategoryList = new TagSqlContext().GetCategory(tempPost.Id);
            tempPost.Tags.AddRange(taglist);
            tempPost.Categories.AddRange(CategoryList);
            _connection.Close();

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


    }
}
