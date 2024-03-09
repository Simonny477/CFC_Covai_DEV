using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using System.Net.Http.Formatting;
using CFCCoimbatore.Models;

namespace CFCCoimbatore.BAL
{
    public class YouTubeApiCall
    {
        public string Url {  get; set; }
        public string UrlParameters { get; set; }

        public string ChannelId { get; set; }
        public string ApiKey { get; set; }
        public string PlayListId { get; set; }
        public YoutubeVideos GetVideoList()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Url);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

                // List data response.
                HttpResponseMessage response = client.GetAsync(UrlParameters).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.

                HttpContent responseContent = response.Content;
                if (response.IsSuccessStatusCode)
                {
                    // Parse the response body.
                    var youtubeVideos = response.Content.ReadAsAsync<YoutubeVideos>().Result;
                    return youtubeVideos;
                }

               client.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return new YoutubeVideos();

        }
    }
}