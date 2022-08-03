using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CicdApp.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
