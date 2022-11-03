using System.ComponentModel.DataAnnotations;
using System.Net;

namespace ZelfVerzonnenDatabase.Entities
{
    public class Book : BaseEntity
    {
        public Book()
        {
            //const string WEBSERVICE_URL = "https://api2.isbndb.com/book/9781934759486";

            //try
            //{
            //    var webRequest = WebRequest.Create(WEBSERVICE_URL);

            //    if (webRequest != null)
            //    {
            //        webRequest.Method = "GET";
            //        webRequest.ContentType = "application/json";
            //        webRequest.Headers["Authorization"] = "YOUR_REST_KEY";

            //        //Get the response
            //        WebResponse wr = webRequest.GetResponseAsync().Result;
            //        Stream receiveStream = wr.GetResponseStream();
            //        StreamReader reader = new StreamReader(receiveStream);

            //        string content = reader.ReadToEnd();

            //        Title = content.
            //        Binding = "";
            //        Language = "";
            //        Cover = null;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
        }

        [Key]
        public int Id { get; set; }

        [Range(0, 9999999999999), Required,] //regex?
        public ulong ISBN { get; set; }

        [Required]
        public string Title { get; set; }

        public string Binding { get; set; }

        [Required, MinLength(2), MaxLength(2)]
        public string Language { get; set; }

        public string CoverImage { get; set; }
    }
}