using Microsoft.VisualStudio.TestTools.UnitTesting;
using FontysMadeSteam.DAL.Context;
using FontysMadeSteam.Model;
using System.Collections.Generic;

namespace DALUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        GameSQLContext Gamecontext = new GameSQLContext();
        TagSqlContext tagContext = new TagSqlContext();
        [TestMethod]
        public void TestMethod1()
        {
           WpPost post =  Gamecontext.GetWpPostById(401);
            string expected = "Spectrum";

            Assert.AreEqual(post.Title, expected);
            
        }

        [TestMethod]
        public void GetCategoryTest()
        {
            List<string> Categories = new List<string>();

            Categories.AddRange(tagContext.GetCategory(401));
            
        }
    }
}
