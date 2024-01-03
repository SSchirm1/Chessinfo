using HtmlAgilityPack;

namespace Chessinfo.Services
{
    public class FetchFideratingService
    {
        public async Task<int> fetchFideRating(string fideId)
        {
            string url = "https://ratings.fide.com/profile/" + fideId;

            using (HttpClient httpClient = new HttpClient())
            {
                {
                    string html = await httpClient.GetStringAsync(url);
                    HtmlDocument htmlDocument = new HtmlDocument();
                    htmlDocument.LoadHtml(html);

                    // Corrected XPath selector
                    HtmlNodeCollection nodes = htmlDocument.DocumentNode.SelectNodes("//div[@class='profile-top-rating-data_gray']");

                    if (nodes != null)
                    {
                        foreach (HtmlNode node in nodes)
                        {
                            // Extract and display the desired data
                            Console.WriteLine(node.InnerHtml);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No matching nodes found.");
                    }
                }
                return 10;
            }
        }
    }
}
