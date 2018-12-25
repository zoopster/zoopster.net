using ExpressMVC.UI;

namespace ExpressMVC.Models.Shortcodes
{
    public class TestimonialsModel
    {
        public TestimonialsModel()
        {
            this.UIProps = new UIProp();
        }

        public UIProp UIProps { get; set; }

        /// <summary>
        /// Author photo source
        /// </summary>
        public string PhotoSrc { get; set; }

        /// <summary>
        /// Author name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Author position
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Sets or gets the Author description
        /// </summary>
        public string Description { get; set; }

        public class UIProp
        {
            public UIProp()
            {
                this.Style = TestimonialStyle.Style1;
            }

            public TestimonialStyle Style { get; set; }
        }
    }
}