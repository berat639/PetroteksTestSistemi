using System.Collections.Generic;
using Petroteks.Entities.Concreate;

namespace Petroteks.Bll.Helpers
{
    public static class WebsiteContext
    {
        //public static SavedWebsite SavedWebsite { get; set; }
        public static ICollection<Website> Websites { get; set; }
    }
}
