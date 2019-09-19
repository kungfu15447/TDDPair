using FunBag;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestBag
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            IBag bag = new Bag();
            int count = bag.CountSize();
            bag.Add(10);
            int afterCount = bag.CountSize();
            Assert.IsTrue(afterCount > count);
        }

        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void TestRemoveEmpty()
        {
            IBag bag = new Bag();
            int i = bag.Remove();
        }

        [TestMethod]
        public void TestRemove()
        {
            IBag bag = new Bag();
            bag.Add(2);
            bag.Add(3);
            bag.Add(4);
            int countBR = bag.CountSize();
            bag.Remove();
            int countAR = bag.CountSize();
            Assert.IsTrue(countBR-1 == countAR);
        }

        [TestMethod]
        public void TestRemoveSmallest()
        {
            IBag bag = new Bag();
            bag.Add(4);
            bag.Add(3);
            bag.Add(2);
            int removedItem = bag.Remove();
            Assert.IsTrue(removedItem == 2);
        }
    }
}
