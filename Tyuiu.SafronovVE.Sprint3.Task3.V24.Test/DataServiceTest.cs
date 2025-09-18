using Tyuiu.SafronovVE.Sprint3.Task3.V24.Lib;
namespace Tyuiu.SafronovVE.Sprint3.Task3.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharInString()
        {
            DataService ds = new DataService();
            string value;
            char replaceable, replacement;
            value = "gft hggt ntg";
            replaceable = 'g';
            replacement = '*';
            var res = ds.ReplaceCharInString(value, replaceable, replacement);
            var wait = "*ft h**t nt*";
            Assert.AreEqual(wait, res);
        }
    }
}
