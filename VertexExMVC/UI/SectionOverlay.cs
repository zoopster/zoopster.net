using System;

namespace ExpressMVC.UI
{
    public class SectionOverlay
    {
        public OverlayType Type { get; set; }
        public Opacity Opacity { get; set; }

        public SectionOverlay(OverlayType type, Opacity opacity)
        {
            this.Type = type;
            this.Opacity = opacity;
        }

        public string GetCSSClass()
        {
            string overlayClass = string.Empty;
            if (this.Type == OverlayType.Dark)
            {
                overlayClass += "overlay overlay-color-dark overlay-show";
            }
            else if (this.Type == OverlayType.Light)
            {
                overlayClass += "overlay overlay-color-light overlay-show";
            }

            if (this.Opacity != Opacity.None)
            {
                string opacityClass = Enum.GetName(typeof(Opacity), this.Opacity);
                if (!string.IsNullOrEmpty(opacityClass))
                {
                    opacityClass = opacityClass.ToLower().Replace("o_", "overlay-op-");
                    overlayClass += " " + opacityClass;
                }
            }
            return overlayClass;
        } 
    }

    public enum OverlayType
    {
        Light,
        Dark
    }
}