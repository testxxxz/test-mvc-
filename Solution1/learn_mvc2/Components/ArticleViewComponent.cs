using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using learn_mvc2.Models;

namespace MyApp.ViewComponents
{
    public class ArticleViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int count)
        {



            List<Article> articles = new List<Article> {

            new Article {title="Top 3 JavaScript\r\n\t\t\t\t\t\tFrameworks",image="~/assets/images/blog/blog-post-thumb-card-1.jpg",text="Project intro lorem ipsum dolor sit amet, consectetuer\r\n\t\t\t\t\t\t\t\t\tadipiscing elit. Cum sociis natoque penatibus et magnis dis parturient\r\n\t\t\t\t\t\t\t\t\tmontes."},
            new Article {title="About Remote\r\n\t\t\t\t\t\t\t\tWorking",image="~/assets/images/blog/blog-post-thumb-card-2.jpg",text="\tLorem ipsum dolor sit amet, consectetuer adipiscing elit.\r\n\t\t\t\t\t\t\t\t\tCum sociis natoque penatibus et magnis dis parturient montes, nascetur\r\n\t\t\t\t\t\t\t\t\tridiculus mus."},
            new Article {title="Top 3 JavaScript\r\n\t\t\t\t\t\tFrameworks",image="~/assets/images/blog/blog-post-thumb-card-3.jpg",text="Project intro lorem ipsum dolor sit amet, consectetuer\r\n\t\t\t\t\t\t\t\t\tadipiscing elit. Cum sociis natoque penatibus et magnis dis parturient\r\n\t\t\t\t\t\t\t\t\tmontes."},
            
            };

           




            return View(articles);
        }
    }
}
