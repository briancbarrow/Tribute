using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tribute.Models
{
    public class SingleTribute
    {
        public int Id { get; set; }
        public string TributeTitle { get; set; }
        public string BioDescriptionHtml { get; set; }
        public string ImageLink { get; set; }
        public string ExternalLink { get; set; }
        public BioDate[] BioDates { get; set; }

        public string DisplayText
        {
            get
            {
                return TributeTitle;
            }
        }

        //public string DisplayImageLink
        //{
        //    get
        //    {
        //        return 
        //    }
        //}
    }

    
}