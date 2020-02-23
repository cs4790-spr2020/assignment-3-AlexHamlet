using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.DataStore;

namespace BlabberApp.DataStoreTest
{
    [TestClass]
    public class UnitTest1
    {
        InMemoryDataStore imd;
        [TestMethod]
        public void TestMethod1()
        {
            imd = new InMemoryDataStore();
            
        }
    }
}
