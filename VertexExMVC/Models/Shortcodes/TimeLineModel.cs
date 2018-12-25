using System;
using System.Collections.Generic;

namespace ExpressMVC.Models.Shortcodes
{
    public class TimeLineModel
    {
        public TimeLineModel()
        {
            this.TimeLineType = TimeLineTypes.Type1;
            this.TimeLines = new List<TimeLineItemModel>();
        }

        public TimeLineTypes TimeLineType { get; set; }
        public List<TimeLineItemModel> TimeLines { get; set; }
    }

    public class TimeLineItemModel
    {
        public TimeLineItemModel()
        {
            this.Date = DateTime.Today;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }

    public enum TimeLineTypes
    {
        Type1,
        Type2
    }
}