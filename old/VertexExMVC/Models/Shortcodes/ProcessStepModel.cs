using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpressMVC.Models.Shortcodes
{
    public class ProcessStepModel: ShortcodeModelBase
    {
        public ProcessStepModel()
        {
            this.Items = new List<ProcessStepItemModel>(); 
        }

        public List<ProcessStepItemModel> Items { get; set; } 
    }

    public class ProcessStepItemModel
    {
        public ProcessStepItemModel()
        {
            this.State = ProcessStepStates.Complate;
        }

        public ProcessStepStates State { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public AnimationModel Animation { get; set; }
        public string Icon { get; set; }
    }

    public enum ProcessStepStates
    {
        Complate,
        Active,
        Disabled
    }
}