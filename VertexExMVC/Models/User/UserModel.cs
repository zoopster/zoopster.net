namespace ExpressMVC
{
    public class UserModel
    {
        public UserModel()
        {
            this.UserName = "Express";
            this.Avatar = "/Content/img/avatars/a1.jpeg";
            this.SeName = "#";
        } 

        public string UserName { get; set; }
        public string Avatar { get; set; }
        public string SeName { get; set; }
    }
}