using Tyuiu.KorotkovNS.Sprint3.Task7.V1.Lib;
namespace Tyuiu.KorotkovNS.Sprint3.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWitArray;
            valueWitArray = new double[len];

            valueWitArray[0] = -12.18;
            valueWitArray[1] = 16.03;
            valueWitArray[2] = 18.87;
            valueWitArray[3] = 4.96;
            valueWitArray[4] = -9.99;
            valueWitArray[5] = -2.00;
            valueWitArray[6] = 2.16;
            valueWitArray[7] = -7.54;
            valueWitArray[8] = -22.76;
            valueWitArray[9] = -20.45;
            valueWitArray[10] = 7.77;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWitArray, res);
        }
    }
}