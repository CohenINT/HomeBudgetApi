using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System.Net.Http;
using System.Threading.Tasks;

namespace UnitTestBudget
{

    [TestClass]
    public class Tests
    {
        
        private static HttpClient _client { set; get; }

        public Tests()
        {
            _client = new HttpClient();
        }
        

        [TestMethod]
        public async Task TestGenerateReport()
        {
            _client.GetAsync("http://serverlist.renegade-x.com/servers.jsp?id=RX-BOT-CABAL");
        }
    }
}