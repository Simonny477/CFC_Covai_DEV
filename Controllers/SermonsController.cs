using CFCCoimbatore.BAL;
using CFCCoimbatore.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace CFCCoimbatore.Controllers
{
    public class SermonsController : Controller
    {
        public ActionResult Sermons()
        {

            return View();
        }

        public ActionResult WedSermons()
        {
            YouTubeApiCall ytCall = new YouTubeApiCall();
            Configuration config = WebConfigurationManager.OpenWebConfiguration("/appSettings.xml");
            ytCall.ApiKey = config.AppSettings.Settings["YTApiKey"].Value;
            ytCall.ChannelId = config.AppSettings.Settings["ChannelId"].Value;
            ytCall.PlayListId = config.AppSettings.Settings["WedPlayListId"].Value;

            List<SermonDetail> sermonDetails = new List<SermonDetail>();
            
            ytCall.Url = "https://www.googleapis.com/youtube/v3/playlistItems";
            ytCall.UrlParameters = string.Concat("?channelId=",ytCall.ChannelId,"&key=",ytCall.ApiKey, "&part=snippet,contentDetails&playlistId=", ytCall.PlayListId,"&maxResults=50");
            var youtubeVideos = ytCall.GetVideoList();
            if (youtubeVideos != null && youtubeVideos.items != null && youtubeVideos.items.Any())
            {
                foreach (var yt in youtubeVideos.items)
                {
                    sermonDetails.Add(new SermonDetail() { Description = yt.snippet.description, PostedOn = yt.contentDetails.videoPublishedAt.ToString("dd MMM yyyy"), PostedOnDt = yt.contentDetails.videoPublishedAt, ThumbNailPath = yt.snippet.thumbnails.maxres.url, Title = yt.snippet.title, VideoId = yt.snippet.resourceId.videoId, speaker = "Bro. Samuel" });
                }
                var defaultDetails = sermonDetails.OrderByDescending(a => a.PostedOnDt).FirstOrDefault();
                ViewBag.DefaultVideo = defaultDetails.VideoId;
                ViewBag.DefaultVideoDesc = defaultDetails.Description;
                ViewBag.DefaultVideoTitle = defaultDetails.Title;
            }
            
            return View(sermonDetails.OrderByDescending(a => a.PostedOnDt).ToList());
        }

        public ActionResult SunSermons()
        {
            YouTubeApiCall ytCall = new YouTubeApiCall();
            Configuration config = WebConfigurationManager.OpenWebConfiguration("/appSettings.xml");
            ytCall.ApiKey = config.AppSettings.Settings["YTApiKey"].Value;
            ytCall.ChannelId = config.AppSettings.Settings["ChannelId"].Value;
            ytCall.PlayListId = config.AppSettings.Settings["SunPlayListId"].Value;

            List<SermonDetail> sermonDetails = new List<SermonDetail>();

            ytCall.Url = "https://www.googleapis.com/youtube/v3/playlistItems";
            ytCall.UrlParameters = string.Concat("?channelId=", ytCall.ChannelId, "&key=", ytCall.ApiKey, "&part=snippet,contentDetails&playlistId=", ytCall.PlayListId, "&maxResults=50");
            var youtubeVideos = ytCall.GetVideoList();
            if (youtubeVideos != null && youtubeVideos.items != null && youtubeVideos.items.Any())
            {
                foreach (var yt in youtubeVideos.items)
                {
                    if (yt.snippet.thumbnails != null && yt.snippet.thumbnails.high != null)
                    {
                        sermonDetails.Add(new SermonDetail() { Description = yt.snippet.description, PostedOn = yt.contentDetails.videoPublishedAt.ToString("dd MMM yyyy"), PostedOnDt = yt.contentDetails.videoPublishedAt, ThumbNailPath = yt.snippet.thumbnails.maxres.url, Title = yt.snippet.title, VideoId = yt.snippet.resourceId.videoId, speaker = "Bro. Samuel" });
                    }
                }

                var defaultDetails = sermonDetails.OrderByDescending(a => a.PostedOnDt).FirstOrDefault();
                ViewBag.DefaultVideo = defaultDetails.VideoId;
                ViewBag.DefaultVideoDesc = defaultDetails.Description;
                ViewBag.DefaultVideoTitle = defaultDetails.Title;
            }

            return View(sermonDetails.OrderByDescending(a => a.PostedOnDt).ToList());

        }

    }
}