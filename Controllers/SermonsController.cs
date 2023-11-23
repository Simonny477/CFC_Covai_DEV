using CFCCoimbatore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

            List<SermonDetail> sermonDetails = new List<SermonDetail>();

            sermonDetails.Add(new SermonDetail() { Description = "கீழ்ப்படிதலினாலே பூரணத்தை நோக்கி கடந்து போவோமாக", PostedOn = "04-10-2023", ThumbNailPath = "~/Images/YT-thumbnails/01.11.23_Wed.jpg", Title = "Press on to perfection in obedience", VideoId = "rfqo7vhCyZg", speaker = "Bro. Vedayan" });
            sermonDetails.Add(new SermonDetail() { Description = "கீழ்ப்படிதலினாலே பூரணத்தை நோக்கி கடந்து போவோமாக", PostedOn = "04-10-2023", ThumbNailPath = "~/Images/YT-thumbnails/29.10.23_Sunday.jpg", Title = "தேவன் தாம் வாக்குதத்தம் பண்ணினவைகளை தமது உத்தமமானவர்கள் மூலமாக நிறைவேற்ற வல்லவராக இருக்கிறார்.", VideoId = "8sHnWMQeu2k", speaker = "Bro. Victor" });
            sermonDetails.Add(new SermonDetail() { Description = "கீழ்ப்படிதலினாலே பூரணத்தை நோக்கி கடந்து போவோமாக", PostedOn = "04-10-2023", ThumbNailPath = "~/Images/YT-thumbnails/12.11.23_Wed.jpg", Title = "Sunday கீழ்ப்படிதலினாலே பூரணத்தை நோக்கி கடந்து போவோமாக", VideoId = "a-WFtXAwjsg", speaker = "Bro. Samuel" });

            return View(sermonDetails);
        }

        public ActionResult SunSermons()
        {
            List<SermonDetail> sermonDetails = new List<SermonDetail>();

            sermonDetails.Add(new SermonDetail() { Description = "கீழ்ப்படிதலினாலே பூரணத்தை நோக்கி கடந்து போவோமாக", PostedOn = "04-10-2023", ThumbNailPath = "~/Images/YT-thumbnails/01.11.23_Wed.jpg", Title = "Press on to perfection in obedience", VideoId = "rfqo7vhCyZg", speaker = "Bro. Vedayan" });
            sermonDetails.Add(new SermonDetail() { Description = "கீழ்ப்படிதலினாலே பூரணத்தை நோக்கி கடந்து போவோமாக", PostedOn = "04-10-2023", ThumbNailPath = "~/Images/YT-thumbnails/29.10.23_Sunday.jpg", Title = "தேவன் தாம் வாக்குதத்தம் பண்ணினவைகளை...", VideoId = "8sHnWMQeu2k", speaker = "Bro. Victor" });
            sermonDetails.Add(new SermonDetail() { Description = "கீழ்ப்படிதலினாலே பூரணத்தை நோக்கி கடந்து போவோமாக", PostedOn = "04-10-2023", ThumbNailPath = "~/Images/YT-thumbnails/12.11.23_Wed.jpg", Title = "Sunday கீழ்ப்படிதலினாலே பூரணத்தை நோக்கி...", VideoId = "a-WFtXAwjsg", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "கீழ்ப்படிதலினாலே பூரணத்தை நோக்கி கடந்து போவோமாக", PostedOn = "04-10-2023", ThumbNailPath = "~/Images/YT-thumbnails/01.11.23_Wed.jpg", Title = "Press on to perfection in obedience", VideoId = "rfqo7vhCyZg", speaker = "Bro. Vedayan" });
            sermonDetails.Add(new SermonDetail() { Description = "கீழ்ப்படிதலினாலே பூரணத்தை நோக்கி கடந்து போவோமாக", PostedOn = "04-10-2023", ThumbNailPath = "~/Images/YT-thumbnails/29.10.23_Sunday.jpg", Title = "தேவன் தாம் வாக்குதத்தம் பண்ணினவைகளை...", VideoId = "8sHnWMQeu2k", speaker = "Bro. Victor" });
            sermonDetails.Add(new SermonDetail() { Description = "கீழ்ப்படிதலினாலே பூரணத்தை நோக்கி கடந்து போவோமாக", PostedOn = "04-10-2023", ThumbNailPath = "~/Images/YT-thumbnails/12.11.23_Wed.jpg", Title = "Sunday கீழ்ப்படிதலினாலே பூரணத்தை நோக்கி...", VideoId = "a-WFtXAwjsg", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "கீழ்ப்படிதலினாலே பூரணத்தை நோக்கி கடந்து போவோமாக", PostedOn = "04-10-2023", ThumbNailPath = "~/Images/YT-thumbnails/01.11.23_Wed.jpg", Title = "Press on to perfection in obedience", VideoId = "rfqo7vhCyZg", speaker = "Bro. Vedayan" });
            sermonDetails.Add(new SermonDetail() { Description = "கீழ்ப்படிதலினாலே பூரணத்தை நோக்கி கடந்து போவோமாக", PostedOn = "04-10-2023", ThumbNailPath = "~/Images/YT-thumbnails/29.10.23_Sunday.jpg", Title = "தேவன் தாம் வாக்குதத்தம் பண்ணினவைகளை...", VideoId = "8sHnWMQeu2k", speaker = "Bro. Victor" });
            sermonDetails.Add(new SermonDetail() { Description = "கீழ்ப்படிதலினாலே பூரணத்தை நோக்கி கடந்து போவோமாக", PostedOn = "04-10-2023", ThumbNailPath = "~/Images/YT-thumbnails/12.11.23_Wed.jpg", Title = "Sunday கீழ்ப்படிதலினாலே பூரணத்தை நோக்கி...", VideoId = "a-WFtXAwjsg", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "கீழ்ப்படிதலினாலே பூரணத்தை நோக்கி கடந்து போவோமாக", PostedOn = "04-10-2023", ThumbNailPath = "~/Images/YT-thumbnails/01.11.23_Wed.jpg", Title = "Press on to perfection in obedience", VideoId = "rfqo7vhCyZg", speaker = "Bro. Vedayan" });
            sermonDetails.Add(new SermonDetail() { Description = "கீழ்ப்படிதலினாலே பூரணத்தை நோக்கி கடந்து போவோமாக", PostedOn = "04-10-2023", ThumbNailPath = "~/Images/YT-thumbnails/29.10.23_Sunday.jpg", Title = "தேவன் தாம் வாக்குதத்தம் பண்ணினவைகளை...", VideoId = "8sHnWMQeu2k", speaker = "Bro. Victor" });
            sermonDetails.Add(new SermonDetail() { Description = "கீழ்ப்படிதலினாலே பூரணத்தை நோக்கி கடந்து போவோமாக", PostedOn = "04-10-2023", ThumbNailPath = "~/Images/YT-thumbnails/12.11.23_Wed.jpg", Title = "Sunday கீழ்ப்படிதலினாலே பூரணத்தை நோக்கி...", VideoId = "a-WFtXAwjsg", speaker = "Bro. Samuel" });

            return View(sermonDetails);
            
        }

    }
}