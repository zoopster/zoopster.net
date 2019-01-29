namespace ExpressMVC.Models.Common
{
    public partial class HeaderLogoModel
    {
        public HeaderLogoModel()
        {
            this.LogoSrc = "/Content/img/logo.png";
            this.TransparentLogoSrc = "/Content/img/logo-white.png";
            this.Width = 106;
            this.Height = 69;
            this.Alt = "Express";
        }

        public string LogoSrc { get; set; }
        public string TransparentLogoSrc { get; set; }

        /// <summary>
        /// Set the logo width
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Set the logo height
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Set the HTML image alt atribute
        /// </summary>
        public string Alt { get; set; }
    }
}