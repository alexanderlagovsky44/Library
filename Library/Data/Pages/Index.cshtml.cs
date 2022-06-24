using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<Book> Books { get; private set; } = new List<Book>();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Books.Add(new Book
            {
                Id = 1
            });
            Books.Add(new Book
            {
                Id = 2
            });
            Books.Add(new Book
            {
                Id = 3
            });
        }
    }
}