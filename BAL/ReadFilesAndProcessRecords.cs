using CFCCoimbatore.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using WebGrease.Css.Ast.Selectors;

namespace CFCCoimbatore.BAL
{
    public class ReadFilesAndProcessRecords
    {
        public List<MeetingDetails> ReadMeetingDetails()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string textFile = path + @"Docs\upcomingmeetings.txt";

            if (File.Exists(textFile))
            {
                // Read a text file line by line.
                string[] lines = File.ReadAllLines(textFile);
                List<MeetingDetails> meetingDetails = new List<MeetingDetails>();
                foreach (string line in lines)
                {
                    var details = line.Split('|');
                    var date = details[2].Split('-');

                    var meeting = new MeetingDetails();
                    meeting.MeetingName = details[0];
                    meeting.MeetingDate = DateTime.ParseExact(details[2] + " " + details[1], "MMM-dd-yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                    meeting.MeetingLink = details[3];

                    meeting.MeetingDateString = string.Concat(meeting.MeetingDate.ToString("MMM"), " ", meeting.MeetingDate.ToString("dd"), ", ", meeting.MeetingDate.ToString("yyyy"), " ", meeting.MeetingDate.ToString("HH:mm"));
                    var dateString = meeting.MeetingDate.ToLongDateString().Split(' ');
                    
                    meetingDetails.Add(meeting);
                }

                return meetingDetails;
            }

            return new List<MeetingDetails>();
        }

        public List<ContactUs> ReadContact()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string textFile = path + @"Docs\contactpersons.txt";

            if (File.Exists(textFile))
            {
                // Read a text file line by line.
                string[] lines = File.ReadAllLines(textFile);
                List<ContactUs> contactDetails = new List<ContactUs>();
                foreach (string line in lines)
                {
                    var details = line.Split('|');

                    var contact = new ContactUs();
                    contact.ContactName = details[0];
                    contact.ContactNumber = details[1];
                    contactDetails.Add(contact);
                }

                return contactDetails;
            }

            return new List<ContactUs>();
        }
    }
}