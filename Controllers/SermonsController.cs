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

            sermonDetails.Add(new SermonDetail() { Description = "பூமிக்குரியா காரியங்களில் சுகபோகமாய் இருப்பவர்கள் கர்த்தருடைய வருகையை தேட மாட்டார்கள்", PostedOn = "02-08-2023", ThumbNailPath = "/Images/YT-thumbnails-Wed/02.08.23_Wed.jpg", Title = "Those who find their comfort on...", VideoId = "SEJPr_DLdGo", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "தேவனுடைய கிருபைக்கு உண்மையுள்ள உக்கிராணக்காராக இருக்க வேண்டும்", PostedOn = "23-08-2023", ThumbNailPath = "/Images/YT-thumbnails-Wed/23.08.23_Wed.jpg", Title = "Be a faithful steward...", VideoId = "Qlqj9JEW6Vo", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "யாருக்கெல்லாம் இயேசு முதலாம் தரம் பிரசன்னம் ஆனாரோ, அவர்களுக்கே இரண்டாம் தரம் பிரசன்னம் ஆவார்", PostedOn = "16-08-2023", ThumbNailPath = "/Images/YT-thumbnails-Wed/16.08.23_Wed.jpg", Title = "Jesus will appear for a second time...", VideoId = "0_TY9dOGqbU", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "நம்மிடத்தில் ஒப்புவிக்கப்பட்டவைகளுக்குரிய கணக்கை நாம் ஒப்புவித்தாக வேண்டும்", PostedOn = "09-08-2023", ThumbNailPath = "/Images/YT-thumbnails-Wed/09.08.23_Wed.jpg", Title = "We need to give an account...", VideoId = "EHsNT_BlRbs", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "தெரிந்துகொள்ளபட்டவர்கள் மத்தியில் நீங்கள் காணப்படுவீர்களா? ", PostedOn = "28-06-2023", ThumbNailPath = "/Images/YT-thumbnails-Wed/28.06.23_Wed.jpg", Title = "Will you be found among the chosen?...", VideoId = "PRWigJMPt3I", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "சாத்தானுடைய தலையை நசுக்கும் ஒர் விசுவாசம்", PostedOn = "05-06-2023", ThumbNailPath = "/Images/YT-thumbnails-Wed/05.06.23_Wed.jpg", Title = "A Faith that crushes the head...", VideoId = "MzpN8T8r9Yc", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "சாத்தானுடைய தந்திரங்களை அறிந்து கொள்ளுங்கள்", PostedOn = "12-07-2023", ThumbNailPath = "/Images/YT-thumbnails-Wed/12.07.23_Wed.jpg", Title = "Know the schemes of Satan...", VideoId = "Sv4QmyH9NQo", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "கிறிஸ்தவ ஜீவியத்திற்கு இலக்கை நிர்ணயிக்க வேண்டும்", PostedOn = "19-07-2023", ThumbNailPath = "/Images/YT-thumbnails-Wed/19.07.23_Wed.jpg", Title = "Set the Goal in Christian Life ...", VideoId = "bybNl8A59B4", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "அழைக்கப்பட்ட அழைப்புக்குப் பாத்திரவான்களாய் வாழவேண்டும்-பாகம் 2", PostedOn = "26-07-2023", ThumbNailPath = "/Images/YT-thumbnails-Wed/26.07.23_Wed.jpg", Title = "Live a life worthy of...", VideoId = "PIEhFmpJtSc", speaker = "Bro. Samuel" });

            return View(sermonDetails);
        }

        public ActionResult SunSermons()
        {
            List<SermonDetail> sermonDetails = new List<SermonDetail>();

            sermonDetails.Add(new SermonDetail() { Description = "கீழ்ப்படிதலினாலே பூரணத்தை நோக்கி கடந்து போவோமாக", PostedOn = "19-11-2023", ThumbNailPath = "/Images/YT-thumbnails-Sun/19.11.23_Sun.jpg", Title = "Press on to perfection in obedience", VideoId = "a-WFtXAwjsg", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "கீழ்ப்படிதல் என்பது மட்டுமே நமது கிறிஸ்தவ ஜீவியத்திற்கு தேவையான ஒரே ஒரு காரியம்", PostedOn = "12-11-2023", ThumbNailPath = "/Images/YT-thumbnails-Sun/12.11.23_Sun.jpg", Title = "Obedience is the only one thing needed...", VideoId = "pllcH32sOXU", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "இயேசு கிறிஸ்துவின் தாழ்மை மற்றும் கீழ்ப்படிதல் எனும் வெளிப்பாட்டின்மேல் தான் சபை கட்டப்படுகிறது", PostedOn = "05-11-2023", ThumbNailPath = "/Images/YT-thumbnails-Sun/05.11.23_Sun.jpg", Title = "The church is built on the revelation...", VideoId = "SxESu25sWEg", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "மற்ற விசுவாசிகளை காட்டிலும் நீங்கள் வித்தியாசமானவராக இருக்க வேண்டும்", PostedOn = "29-10-2023", ThumbNailPath = "/Images/YT-thumbnails-Sun/29.10.23_Sun.jpg", Title = "Be of different spirit from...", VideoId = "zR3f2G-H2Xk", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "கர்த்தருடைய சபையின் மகிமை", PostedOn = "22-10-2023", ThumbNailPath = "/Images/YT-thumbnails-Sun/22.10.23_Sun.jpg", Title = "The Glory of the church of...", VideoId = "x5fNvsLBVD8", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "நித்தியமானதை அறுவடை செய்திடசுபாவத்தின் படியான காரியங்களை விதைப்போமாக", PostedOn = "15-10-2023", ThumbNailPath = "/Images/YT-thumbnails-Sun/15.10.23_Sun.jpg", Title = "Sow natural things to reap...", VideoId = "ywPTOsbo4Sk", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "தேவன் அசுத்தத்தோடு சமரசம் செய்கிறதில்லை", PostedOn = "08-10-2023", ThumbNailPath = "/Images/YT-thumbnails-Sun/08.10.23_Sun.jpg", Title = "God does not compromise with...", VideoId = "vtAeRwY967Q", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "அனைத்து சந்தர்ப்ப சூழ்நிலையிலும் கர்த்தருக்கு ஸ்தோத்திரம் செலுத்துங்கள்", PostedOn = "01-10-2023", ThumbNailPath = "/Images/YT-thumbnails-Sun/01.10.23_Sun.jpg", Title = "Give thanks to the Lord in...", VideoId = "mCYQT9e_FcE", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "சமாதானமும் பரிசுத்தமாகுதலும்", PostedOn = "24-09-2023", ThumbNailPath = "/Images/YT-thumbnails-Sun/24.09.23_Sun.jpg", Title = "Peace and Sanctification...", VideoId = "ussCy90qFYw", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "இயேசு தாம் நேசிக்கிறவர்களை கடிந்து கொண்டு சிட்சிக்கிறார்", PostedOn = "17-09-2023", ThumbNailPath = "/Images/YT-thumbnails-Sun/17.09.23_Sun.jpg", Title = "Those whom Jesus loves He...", VideoId = "GgETe7zLtcY", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "பிதாவானவர் விரும்பும்விதமான தொழுதுகொள்கிறவர்கள்", PostedOn = "10-09-2023", ThumbNailPath = "/Images/YT-thumbnails-Sun/10.09.23_Sun.jpg", Title = "The worshipers whom Father seek...", VideoId = "uv0SuA7KH68", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "கிறிஸ்துவை நமது இருதயத்தில் கர்த்தராக பரிசுத்தம் பண்ணவேண்டும்", PostedOn = "03-09-2023", ThumbNailPath = "/Images/YT-thumbnails-Sun/03.09.23_Sun.jpg", Title = "Sanctity Christ as Lord...", VideoId = "RKtTB5cuszU", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "நமது ஜீவியத்தின் இறுதி வரை தெய்வபக்தியோடும்,உத்தமமாகவும் இருக்க வேண்டும்", PostedOn = "27-08-2023", ThumbNailPath = "/Images/YT-thumbnails-Sun/27.08.23_Sun.jpg", Title = "Be Godly and Faithful...", VideoId = "vEZjeHPu7zc", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "தேவனை சேவிக்க வேண்டுமென்றால் இப்பூமிக்குரிய காரியங்களை அதினதின் இடத்தில் வைக்க வேண்டும்", PostedOn = "20-08-2023", ThumbNailPath = "/Images/YT-thumbnails-Sun/20.08.23_Sun.jpg", Title = "Set right with the earthly things...", VideoId = "srVEkS41sNg", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "இயேசுவின் பிரசன்னமாகுதல் நம்முடைய ஜீவியத்தை மாற்றிவிடும்", PostedOn = "13-08-2023", ThumbNailPath = "/Images/YT-thumbnails-Sun/13.08.23_Sun.jpg", Title = "Appearance of Jesus will change our...", VideoId = "ueZhUIjqnlE", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "கர்த்தருடைய வருகையை பற்றிய சந்தோஷத்தால் நிறைந்திருங்கள்", PostedOn = "06-08-2023", ThumbNailPath = "/Images/YT-thumbnails-Sun/06.08.23_Sun.jpg", Title = "Be filled with the joy of...", VideoId = "iUe7jiSaufg", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "அழைக்கப்பட்ட அழைப்புக்குப் பாத்திரவான்களாய் வாழவேண்டும்", PostedOn = "23-07-2023", ThumbNailPath = "/Images/YT-thumbnails-Sun/23.07.23_Sun.jpg", Title = "Live a life worthy of our calling...", VideoId = "mMx46R289bU", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "நாம் ஜெயங்கொள்ளும் படிக்கு ஓட வேண்டும்", PostedOn = "16-07-2023", ThumbNailPath = "/Images/YT-thumbnails-Sun/16.07.23_Sun.jpg", Title = "Run in such a way that...", VideoId = "g7o9LDQ4LVs", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "தங்களை தீட்டுப்படுத்தி கொள்ளக்கூடாது என்று தீர்மாணித்கொள்பவர்களுக்கு கர்த்தர் உறுதுணையாய் இருப்பார்", PostedOn = "09-07-2023", ThumbNailPath = "/Images/YT-thumbnails-Sun/09.07.23_Sun.jpg", Title = "Lord supports those who make up...", VideoId = "he8c__Hlm6A", speaker = "Bro. Samuel" });
            sermonDetails.Add(new SermonDetail() { Description = "தேவனுடைய வார்த்தையை கனம் பண்ணுதல்", PostedOn = "02-07-2023", ThumbNailPath = "/Images/YT-thumbnails-Sun/02.07.23_Sun.jpg", Title = "Honoring God's Word...", VideoId = "qGIw0lsi-P4", speaker = "Bro. Vedaiyan" });
            sermonDetails.Add(new SermonDetail() { Description = "தன்னை போலவே, தனது சபையும் பரிசுத்தமாக இருக்கவேண்டும் என்று கர்த்தர் விரும்புகிறார்", PostedOn = "25-06-2023", ThumbNailPath = "/Images/YT-thumbnails-Sun/25.06.23_Sun.jpg", Title = "The Lord wants His church to...", VideoId = "dXvGaL5rhnY", speaker = "Bro. Samuel" });
            return View(sermonDetails);
            
        }

    }
}