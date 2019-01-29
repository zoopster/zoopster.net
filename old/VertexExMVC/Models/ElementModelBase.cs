using System.ComponentModel;

namespace ExpressMVC.Models
{
    public class ElementModelBase
    {
        public ElementModelBase()
        {
            this.Name = "Default";
        } 

        public string Name { get; set; } 
        public string ClassName { get; set; }
    }
}