using System.Collections.Generic;
using Petroteks.Entities.Concreate;

namespace Petroteks.MvcUi.Areas.Admin.Data
{
    public static class DataTransferPoint
    {
        public static ICollection<Email> SelectedEmails { get; set; }
    }
}
