using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleDomain.Entities;
using SampleDomain.Interface;
using SampleDomain.Dao;

namespace SampleTest
{
    /// <summary>
    /// Summary description for CatTest
    /// </summary>
    [TestClass]
    public class CatTest
    {
        private ICatDao _catDao;
        public CatTest()
        {
            _catDao = new CatDao();
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void SaveOneCat()
        {
            var cat = new Cat()
            {
                Name = "SampleOne",
                Sex = 'F',
                Weight = 7.4f
            };
            var id = _catDao.SaveCat(cat);
            Assert.AreEqual(_catDao.GetCatById(id).Name, cat.Name);
        }
        [TestMethod]
        public void SaveWrongCat()
        {
            var cat = new Cat()
            {
                Name = "SampleTwo",
                Sex = 'F',
                Weight = 10.0f
            };
            var id = _catDao.SaveCatWithWrongValue(cat);
            Assert.AreNotEqual(_catDao.GetCatById(id).Name, "SampleTwo");
        }
    }
}
