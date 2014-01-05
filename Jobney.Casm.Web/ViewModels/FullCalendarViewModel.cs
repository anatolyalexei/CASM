using System;

namespace Jobney.Casm.Web.ViewModels
{
    public class FullCalendarViewModel
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
    }
}