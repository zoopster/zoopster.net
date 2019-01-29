using ExpressMVC.UI;
using System;
using System.Collections.Generic;

namespace ExpressMVC.Models.Blog
{
    public class BlogPostModel : EntityModelBase
    {
        public BlogPostModel()
        {
            this.Tags = new List<BlogPostTagModel>();
            this.Categiries = new List<BlogCategoryModel>();

            AddNewComment = new AddBlogCommentModel();
            Comments = new List<CommentModel>();

            this.GalleryImageSrc = new List<String>();
            this.PostType = BlogPostType.Standard;
            this.CreatedOn = DateTime.Now;
        }

        /// <summary>
        /// if BlogPostType = Standard set the          ImageSrc            as Src
        /// if BlogPostType = EmbeddedVideo set the     EmbeddedVideoSrc    as Src
        /// if BlogPostType = Html5Video set            Html5VideoSrc       as Src
        /// if BlogPostType = Audio set the             AudioSrc            as Src
        /// if BlogPostType = Blockquote set the        QuoteText           as Src
        /// if BlogPostType = Link set the              LinkText            as Src
        /// </summary>
        public String Src { get; set; }

        /// <summary>
        /// Sets or gets If BlogPostType is ImageGallery or SliderGallery
        /// </summary>
        public List<String> GalleryImageSrc { get; set; }

        public String Title { get; set; }
        public String Body { get; set; }
        public DateTime CreatedOn { get; set; }

        public IList<BlogPostTagModel> Tags { get; set; }
        public List<BlogCategoryModel> Categiries { get; set; }

        public BlogPostType PostType { get; set; }

        public AddBlogCommentModel AddNewComment { get; set; }
        public List<CommentModel> Comments { get; set; }
    }
}