using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookList.Pages.Book
{
    public class IndexModel : PageModel
    {
        public class IndexModel : PageModel
        {
            private readonly ApplicationDbContext _db;
            public IndexModel(ApplicationDbContext db)
            {
                _db = db;
            }

            public void OnGet()
        {
        }
    }
}
