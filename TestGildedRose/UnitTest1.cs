using GildedRose;

namespace TestGildedRose
{
    [TestClass]
    public class UnitTest1
    {
        DateTime DateExpired   = new DateTime(2022, 12, 21);
        DateTime NoDateExpired = new DateTime(2030, 12, 31);

        [TestMethod]
        public void WhenGivenProductReturnsUpdateSellInValue()
        {
            Product myproduct = new Product("Bread", 35, 40, NoDateExpired);
            myproduct.updateProduct();
            Assert.AreEqual(34, myproduct.SellIn);
        }

        [TestMethod]
        public void WhenGivenProductReturnsUpdateQualityValue()
        {
            Product myproduct = new Product("Bread", 35, 40, NoDateExpired);
            myproduct.updateProduct();
            Assert.AreEqual(39, myproduct.Quality);
        }

        [TestMethod]
        public void WhenQualityGoesNegative()
        {
            Product myproduct = new Product("Bread", 11, -1, NoDateExpired);
            myproduct.updateProduct();
            Assert.AreEqual(0, myproduct.Quality);
        }

        [TestMethod]
        public void GetQualityWhenAProductIsExpired ()
        {
            Product myproduct = new Product("Bread", 0, 16, DateExpired);
            myproduct.updateProduct();
            Assert.AreEqual(14, myproduct.Quality);
        }

        [TestMethod]
        public void WhenGivenProductIsAgedBrieReturnsUpdateQualityValue()
        {
            Product myproduct = new Product("Aged Brie", 35, 40, NoDateExpired);
            myproduct.updateProduct();
            Assert.AreEqual(41, myproduct.Quality);
        }

        [TestMethod]
        public void WhenProductQualityGetsOver50()
        {
            Product myproduct = new Product("Aged Brie", 35, 51, NoDateExpired);
            myproduct.updateProduct();
            Assert.AreEqual(50, myproduct.Quality);
        }

        [TestMethod]
        public void WhenProductIsLegendary()
        {
            Product myproduct = new Product("Sulfuras", 35, 40, DateExpired);
            myproduct.updateProduct();
            Assert.AreEqual(40, myproduct.Quality);
        }
        [TestMethod]
        public void GetQualityWithBackstagePasses10DaysDifference()
        {
            Product myproduct = new Product("Aged Brie", 10, 20, DateExpired);
            myproduct.updateProduct();
            Assert.AreEqual(22, myproduct.Quality);
        }
        public void GetQualityWithBackstagePasses5DaysDifference()
        {
            Product myproduct = new Product("Aged Brie", 5, 35, DateExpired);
            myproduct.updateProduct();
            Assert.AreEqual(38, myproduct.Quality);
        }

    }
}