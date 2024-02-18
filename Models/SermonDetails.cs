using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CFCCoimbatore.Models
{
    public class Sermons
    {
        public List<SermonDetail> SermonDetails { get; set; }
    }

    public class SermonDetail
    {
        public string Title { get; set; }
        public string ThumbNailPath { get; set; }
        public string VideoId { get; set; }
        public string Description { get; set; }
        public string PostedOn { get; set; }
        public DateTime PostedOnDt { get; set; }
        public string speaker { get; set; }

    }
}