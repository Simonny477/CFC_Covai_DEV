using CFCCoimbatore.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace CFCCoimbatore.Models
{
    


    public class BookDetails
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string ImageName { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string DetailsPageUrl { get; set; }
        public Catagory Catagory {  get; set; }

    }
}