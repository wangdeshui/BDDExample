using System.Configuration;

namespace BDD.SpecTests
{
    public class TestHelper
    {
        public static string HostUrl = ConfigurationManager.AppSettings["hostaddress"] as string;
    }
}