using Newtonsoft.Json.Linq;

namespace KanyeWest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
            var client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest/";
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var ronResponse = client.GetStringAsync(ronURL).Result;
            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            Console.WriteLine($"Kanye: {kanyeQuote}");
            Console.WriteLine($"Ron: {ronQuote}");
            }
        }
    }
}