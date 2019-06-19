using Microsoft.VisualStudio.TestTools.UnitTesting;
using FontysMadeSteam.DAL.Context;
using FontysMadeSteam.Model;
using System.Collections.Generic;
using System.Linq;

namespace DALUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        GameSQLContext Gamecontext = new GameSQLContext();
        TagSqlContext tagContext = new TagSqlContext();
        [TestMethod]
        public void GetPostById()
        {
           WpPost post =  Gamecontext.GetWpPostById(401);
            string expected = "Spectrum";

            Assert.AreEqual(post.Title, expected);
            
        }

        [TestMethod]
        public void GetCategoryNamesTest()
        {
            List<string> Categories = new List<string>();

            Categories.AddRange(tagContext.GetCategorieNames());
            Assert.IsNotNull(Categories);
            Assert.AreEqual(Categories.Count(), 24);
        }
        [TestMethod]
        public void GetTagNamesTest()
        {
            List<string> Tags = new List<string>();
            Tags.AddRange(tagContext.GetTagNames());
            Assert.IsNotNull(Tags);
            Assert.AreEqual(Tags.Count, 5);
        }
        [TestMethod]
        public void GetAllPosts()
        {
            IEnumerable<WpPost> wpPosts = new List<WpPost>();
            wpPosts = Gamecontext.GetWpPosts();
            Assert.AreEqual(wpPosts.Count(), 67);
        }
    }
}
