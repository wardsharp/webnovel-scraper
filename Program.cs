using HtmlAgilityPack;
using Fizzler.Systems.HtmlAgilityPack;
using System.Text;

namespace webnovel_scraper;

class Program
{
    private static HttpClient _httpClient = new();

    // this helps trick websites into thinking we are normal users (and not a bot, even though we are, in fact, a bot)
    private const string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36";
    public static void Main(){
        // first, get the page HTML
        string pageUrl = "https://mtlnovel.me/read/doomsday-commander/chapter-1-doomsday/";
        
        // prepare the request message
        HttpRequestMessage requestMessage = new()
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(pageUrl)
        };
        requestMessage.Headers.Add("User-Agent", UserAgent);

        // send and validate the request
        HttpResponseMessage responseMessage = _httpClient.Send(requestMessage);

        // throws an exception on invalid HTTP response code
        responseMessage.EnsureSuccessStatusCode();

        // pull out the string content
        string responseContent = responseMessage.Content.ReadAsStringAsync().Result;

        // print out the response to make sure things are working
        System.Console.WriteLine(responseContent);

        // once we have the HTML, parse the document
        var doc = new HtmlDocument();
        doc.LoadHtml(responseContent);

        // loop through each P tag, and add it as a "line" of story
        StringBuilder storyText = new();
        foreach(HtmlNode pTag in doc.DocumentNode.QuerySelectorAll("p"))
        {
            storyText.AppendLine(pTag.InnerText);
        }
    }
}
