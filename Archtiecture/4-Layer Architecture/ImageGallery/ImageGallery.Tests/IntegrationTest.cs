using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImageGallery.Tests
{
    /// <summary>
    /// Summary description for IntegrationTest
    /// </summary>
    [TestClass]
    public class IntegrationTest
    {
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
        public void EntityFrameworkDbInitialize()
        {
            //using (var context = new EFDbContext())
            //{
            //    context.Albums.Add(entity);
            //    context.SaveChanges();
            //    var existingalbum = context.Albums.FirstOrDefault();
            //    //context.Albums.Remove(f);
            //    //context.SaveChanges();
            //}
        }
    }
}
