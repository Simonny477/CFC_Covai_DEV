using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CFCCoimbatore.Utils
{
    public class ConstantsDef
    {
        public const string MailBodyTemplate = "Dear Brother <br/><br/>Greetings from {1} ! <br/> {0} <br/> <br/> Thanks and regards, <br/> Name : {1} <br/> Contact : {2} <br/> Mail : {3}";
        public const string MailSubTemplate = "Contact request from cfccoimbatore.com website";
        public const string CovaiCFCMail = "admin@cfccoimbatore.com";
    }

    public enum Catagory
    {
        All = 0,
        Children = 1,
        Men =2, 
        Women =3,
        Booklet = 4,
    }
}