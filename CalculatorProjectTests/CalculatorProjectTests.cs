//HancockB
//IT221
//Behaviors not implemented: none
//Notes: Test runs without errors (0 errors), runsettings two
//int values are used in the test (see test summary details for
//console writeline), and test passes (true).
using CalculatorProject;
using Microsoft.VisualStudio.TestPlatform.TestHost;
namespace CalculatorProjectTests
{
    [TestClass]
    public class CalculatorProjectTests
    {
        public TestContext? TestContext { get; set; }
        [TestMethod]
        public void CalculatorProjectAdd_5_9_returns_14()
        {
            int x = int.Parse(TestContext.Properties["valueX"].ToString());
            int y = int.Parse(TestContext.Properties["valueY"].ToString());

            //// TestContext?.WriteLine("In test: " + TestContext?.TestName?.ToUpper());
            Calculator c = new Calculator();
            int result = c.Add(x, y);
            System.Console.WriteLine("result: " + result + ", which is equal to 14");
            Assert.AreEqual(14, result);
        }
    }
}