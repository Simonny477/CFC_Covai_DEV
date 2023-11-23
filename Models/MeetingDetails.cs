using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CFCCoimbatore.Models
{
    public class MeetingDetails
    {
        public string MeetingName { get; set; }
        public string MeetingDescription { get; set;}
        public string MeetingDateString { get; set; }
        public string MeetingLink { get; set; }
        public DateTime MeetingDate { get; set; }
        public string MeetingTimeStart { get; set; }
        public string MeetingTimeEnd { get; set; }
    }
}