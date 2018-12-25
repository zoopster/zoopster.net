using ExpressMVC.UI;
using ExpressMVC.Models.Shortcodes; 

namespace ExpressMVC.SampleData
{
    public class AccordionData
    {
        public static AccordionModel GetAccordionModel
        {
            get
            {
                AccordionModel acc = new AccordionModel();

                acc.Items.Add(new AccordionItemModel()
                {
                    Title = "Section One",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam viverra euismod odio, gravida pellentesque urna varius vitae. Sed dui lorem, adipiscing in adipiscing et, interdum nec metus",
                    TitleIcon = Icons.FontAwesome.Shower,
                    IsExpanded = true
                });

                acc.Items.Add(new AccordionItemModel()
                {
                    Title = "Section Two",
                    Content = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 5 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod.",
                    TitleIcon = Icons.FontAwesome.UserCircle
                });

                acc.Items.Add(new AccordionItemModel()
                {
                    Title = "Section Three",
                    Content = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 5 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod.",
                    TitleIcon = Icons.FontAwesome.Star
                });

                return acc;
            }
        }
    }
}