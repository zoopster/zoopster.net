using System;

namespace ExpressMVC.UI
{
    public class TextElement
    {
        public string LabelText { get; set; }
        public Alignment Alignment { get; set; }
        public TextSize TextSize { get; set; }
        public FontWeight FontWeight { get; set; }
        public TextColor TextColor { get; set; }
        public Opacity Opacity { get; set; }

        public TextElement(string labelText)
        {
            this.LabelText = labelText;
        }

        public TextElement(string labelText, TextColor color)
        {
            this.LabelText = labelText;
            this.TextColor = color;
        }

        public override string ToString()
        {
            return LabelText;
        }

        public string GetClassName()
        {
            string returnValue = string.Empty;

            string opacityClass = string.Empty;
            if (this.Opacity != Opacity.None)
            {
                opacityClass = Enum.GetName(typeof(Opacity), this.Opacity);
                if (!string.IsNullOrEmpty(opacityClass))
                {
                    opacityClass = opacityClass.ToLower().Replace("o_", "opacity-");
                    returnValue += opacityClass + " ";
                }
            }

            string textSizeClass = string.Empty;
            if (this.TextSize != TextSize.None)
            {
                textSizeClass = Enum.GetName(typeof(TextSize), this.TextSize);
                if (!string.IsNullOrEmpty(textSizeClass))
                {
                    textSizeClass = textSizeClass.ToLower().Replace("_", "-");
                    returnValue += textSizeClass + " ";
                }
            }

            string fontWeightClass = string.Empty;
            fontWeightClass = Enum.GetName(typeof(FontWeight), this.FontWeight);
            if (!string.IsNullOrEmpty(fontWeightClass))
            {
                fontWeightClass = String.Format("font-weight-{0}", fontWeightClass.ToLower().Replace("_", "-"));
                returnValue += fontWeightClass + " ";
            }

            if (this.TextColor != TextColor.Default)
            {
                switch (this.TextColor)
                {
                    case TextColor.White:
                        returnValue += "text-white";
                        break;
                    case TextColor.Primary:
                        returnValue += "text-color-primary";
                        break;
                    case TextColor.Secondary:
                        returnValue += "text-color-secondary";
                        break;
                    case TextColor.Tertiary:
                        returnValue += "text-color-tertiary";
                        break;
                    case TextColor.Quaternary:
                        returnValue += "text-color-quaternary";
                        break;
                    case TextColor.Dark:
                        returnValue += "text-color-dark";
                        break;
                    default:
                        break;
                } 
            } 

            return returnValue.Trim();
        }
    }
}