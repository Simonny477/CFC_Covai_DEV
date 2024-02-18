using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CFCCoimbatore.Models
{
    public class YoutubeVideos
    {
        public string kind { get; set; }
        public string etag { get; set; }
        //public string nextPageToken { get; set; }
        public List<Items> items { get; set; }
        public PageInfo pageInfo { get; set; }
    }

    public class PageInfo
    {
       public int totalResults { get; set; }
        public int resultsPerPage { get; set; }
    }

    public class Items
    {
        public string kind { get; set;}
        public string etag { get; set;}
        public string id { get; set; }
        public Snippet snippet { get; set; }
        public ContentDetails contentDetails { get; set; }

    }

    public class Snippet
    {
        public DateTime publishedAt { get; set; }
        public string channelId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public Thumbnails thumbnails { get; set; }
        public string channelTitle { get; set; }
        public string playlistId { get; set; }
        public int position { get; set; }
        public ResourceId resourceId { get; set; }
        public string videoOwnerChannelTitle { get; set; }
        public string videoOwnerChannelId { get; set; }

    }

    public class Thumbnails
    {
        public ThumbnailDetails Default { get; set; }
        public ThumbnailDetails medium { get; set; }
        public ThumbnailDetails high { get; set; }
        public ThumbnailDetails standard { get; set; }
        public ThumbnailDetails maxres { get; set; }

    }

    public class ThumbnailDetails
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class ResourceId
    {
        public string kind { get; set; }
        public string videoId { get; set; }
    }

    public class ContentDetails
    {
        public string videoId { get; set; }
        public DateTime videoPublishedAt { get; set; }
    }
       
}