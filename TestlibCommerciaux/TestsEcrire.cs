using libCommerciaux;

namespace TestlibCommerciaux
{
    [TestClass]
    public class TestsEcrire
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arranger
            Commercial c;
            NoteFrais f0, f1;
            c = new Commercial("Jean", "Dupond", 25, 'A');

            //Agir
            f0 = new NoteFrais(new DateTime(2022, 11, 12), c);
            f1 = new NoteFrais(new DateTime(2022, 11, 15), c);

            //Auditer
            Assert.AreEqual(2, c.getMesNoteFrais().Count);
        }
    }
}