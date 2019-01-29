namespace ExpressMVC.Models.Blog
{
    public partial class BlogPostTagModel: ShortcodeModelBase
    {
        public string Name { get; set; }
        public string SeName { get; set; }
        public int BlogPostCount { get; set; }
    }
}