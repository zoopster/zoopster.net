using ExpressMVC.UI;
using System;
using System.Web.Mvc;

namespace ExpressMVC.Models.Shortcodes
{
    public class AnimationModel : ShortcodeModelBase
    {
        public AnimationModel()
        {
            this.Type = AnimationType.None;
        }

        public AnimationModel(AnimationType animType, int delay)
        {
            this.Type = animType;
            this.Delay = delay;
        }

        public AnimationType Type { get; set; }
        public int Delay { get; set; }
        public String Content { get; set; }
    }
}