using ExpressMVC.Models.Blog;
using ExpressMVC.UI;
using System.Collections.Generic;

namespace ExpressMVC.SampleData
{
    public class BlogData
    {
        public static CommentListModel SampleComments
        {
            get
            {
                CommentListModel model = new CommentListModel();

                var comment1 = new CommentModel();

                return model;
            }
        }
        public static BlogListModel SampleData
        {
            get
            {
                BlogListModel model = new BlogListModel();
                var items = new List<BlogPostModel>();

                var artCategory = new BlogCategoryModel() { Id = 1, Name = "Art", SeName = "#" };
                var photographyCategory = new BlogCategoryModel() { Id = 2, Name = "Photography", SeName = "#" };
                var mockupCategory = new BlogCategoryModel() { Id = 3, Name = "Mockup", SeName = "#" };
                var brandingCategory = new BlogCategoryModel() { Id = 4, Name = "Branding", SeName = "#" };
                var identityCategory = new BlogCategoryModel() { Id = 5, Name = "Identity", SeName = "#" };

                var designTag = new BlogPostTagModel() { Name = "Design" };
                var codeTag = new BlogPostTagModel() { Name = "Code" };
                var mvcTag = new BlogPostTagModel() { Name = "MVC" };
                var testTag = new BlogPostTagModel() { Name = "Test" };

                model.AvailableCategiries.Add(artCategory);
                model.AvailableCategiries.Add(photographyCategory);
                model.AvailableCategiries.Add(mockupCategory);
                model.AvailableCategiries.Add(brandingCategory);
                model.AvailableCategiries.Add(identityCategory);


                BlogPostModel acc = new BlogPostModel();
                acc.Id = 1;
                acc.Title = "This is a standard post with preview image";
                acc.Src = "/Content/img/blog/01.jpg";
                acc.Body = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Cupiditate, asperiores quod est tenetur in. Eligendi, deserunt, blanditiis est quisquam doloribus voluptate id aperiam ea ipsum magni aut perspiciatis rem voluptatibus officia eos rerum deleniti quae nihil facilis repellat atque vitae voluptatem libero at eveniet veritatis ab facere.";
                acc.PostType = BlogPostType.Standard;
                acc.Categiries = new List<BlogCategoryModel>() { artCategory };
                acc.Tags = new List<BlogPostTagModel>() { designTag, codeTag, testTag, mvcTag };
                items.Add(acc);

                acc = new BlogPostModel();
                acc.Id = 2;
                acc.Title = "This is a standard slider gallery post";
                acc.GalleryImageSrc.Add("/Content/img/blog/02.jpg");
                acc.GalleryImageSrc.Add("/Content/img/blog/05.jpg");
                acc.Body = "Asperiores, tenetur, blanditiis, quaerat odit ex exercitationem pariatur quibusdam veritatis quisquam laboriosam esse beatae hic perferendis velit deserunt soluta iste repellendus officia in neque veniam debitis placeat quo unde reprehenderit eum facilis vitae. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Nihil, reprehenderit!";
                acc.PostType = BlogPostType.SliderGallery;
                acc.Categiries = new List<BlogCategoryModel>() { identityCategory };
                acc.Tags = new List<BlogPostTagModel>() { designTag };
                items.Add(acc);

                acc = new BlogPostModel();
                acc.Id = 3;
                acc.Title = "Amazing Standard Post";
                acc.GalleryImageSrc.Add("/Content/img/blog/03.jpg"); 
                acc.Body = "Asperiores, tenetur, blanditiis, quaerat odit ex exercitationem pariatur quibusdam veritatis quisquam laboriosam esse beatae hic perferendis velit deserunt soluta iste repellendus officia in neque veniam debitis placeat quo unde reprehenderit eum facilis vitae. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Nihil, reprehenderit!";
                acc.PostType = BlogPostType.Standard;
                acc.Categiries = new List<BlogCategoryModel>() { identityCategory };
                acc.Tags = new List<BlogPostTagModel>() { designTag, codeTag };
                items.Add(acc);

                acc = new BlogPostModel();
                acc.Id = 4;
                acc.Title = "This is a standard embedded video post (youtube)";
                acc.Src = "http://www.youtube.com/embed/_xMz2SnSWS4?showinfo=0&amp;controls=1&amp;modestbranding=1";
                acc.Body = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ratione, voluptatem, dolorem animi nisi autem blanditiis enim culpa reiciendis et explicabo tenetur voluptate rerum molestiae eaque possimus exercitationem eligendi fuga. Maiores, sunt eveniet doloremque porro hic exercitationem distinctio sequi adipisci. Nulla, fuga perferendis voluptatum beatae voluptate architecto laboriosam provident deserunt. Saepe!";
                acc.PostType = BlogPostType.EmbeddedVideo;
                acc.Categiries = new List<BlogCategoryModel>() { brandingCategory };
                acc.Tags = new List<BlogPostTagModel>() { designTag };
                items.Add(acc);

                acc = new BlogPostModel();
                acc.Id = 5;
                acc.Title = "This is a standard embedded video post (vimeo)";
                acc.Src = "https://player.vimeo.com/video/77770080";
                acc.Body = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Cupiditate, asperiores quod est tenetur in. Eligendi, deserunt, blanditiis est quisquam doloribus voluptate id aperiam ea ipsum magni aut perspiciatis rem voluptatibus officia eos rerum deleniti quae nihil facilis repellat atque vitae voluptatem libero at eveniet veritatis ab facere.";
                acc.PostType = BlogPostType.EmbeddedVideo;
                acc.Categiries = new List<BlogCategoryModel>() { brandingCategory, mockupCategory };
                acc.Tags = new List<BlogPostTagModel>() { designTag, codeTag, testTag };
                items.Add(acc);

                acc = new BlogPostModel();
                acc.Id = 6;
                acc.Title = "This is a standard HTML5 video post";
                acc.Src = "/Content/img/blog/youths_poster-1024x575.jpg";
                acc.Src = "http://www.html5videoplayer.net/videos/toystory.mp4";
                acc.Body = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Cupiditate, asperiores quod est tenetur in. Eligendi, deserunt, blanditiis est quisquam doloribus voluptate id aperiam ea ipsum magni aut perspiciatis rem voluptatibus officia eos rerum deleniti quae nihil facilis repellat atque vitae voluptatem libero at eveniet veritatis ab facere.";
                acc.PostType = BlogPostType.Html5Video;
                acc.Categiries = new List<BlogCategoryModel>() { mockupCategory, identityCategory };
                acc.Tags = new List<BlogPostTagModel>() { designTag, mvcTag };
                items.Add(acc);

                acc = new BlogPostModel();
                acc.Id = 7;
                acc.Title = "This is a standard link post";
                acc.Src = "Express On Wrapbootstrap";
                acc.Body = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Cupiditate, asperiores quod est tenetur in. Eligendi, deserunt, blanditiis est quisquam doloribus voluptate id aperiam ea ipsum magni aut perspiciatis rem voluptatibus officia eos rerum deleniti quae nihil facilis repellat atque vitae voluptatem libero at eveniet veritatis ab facere.";
                acc.PostType = BlogPostType.Link;
                acc.Categiries = new List<BlogCategoryModel>() { brandingCategory, artCategory };
                acc.Tags = new List<BlogPostTagModel>() { designTag, codeTag, testTag, mvcTag };
                items.Add(acc);

                acc = new BlogPostModel();
                acc.Id = 8;
                acc.Title = "This is a standard audio post";
                acc.Src = "https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/341546259&amp;color=%23ff5500&amp;auto_play=false&amp;hide_related=false&amp;show_comments=true&amp;show_user=true&amp;show_reposts=false&amp;show_teaser=true&amp;visual=true";
                acc.Body = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Cupiditate, asperiores quod est tenetur in. Eligendi, deserunt, blanditiis est quisquam doloribus voluptate id aperiam ea ipsum magni aut perspiciatis rem voluptatibus officia eos rerum deleniti quae nihil facilis repellat atque vitae voluptatem libero at eveniet veritatis ab facere.";
                acc.PostType = BlogPostType.Audio;
                acc.Categiries = new List<BlogCategoryModel>() { photographyCategory };
                acc.Tags = new List<BlogPostTagModel>() { designTag, testTag, mvcTag };
                items.Add(acc);

                
                model.BlogPosts = items;

                return model;
            }
        }
    }
}