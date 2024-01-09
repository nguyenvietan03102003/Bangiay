using Bangiay.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bangiay.Components
{
    [ViewComponent(Name = "Product")]
    public class ProductComponent : ViewComponent
    {
        private readonly DataContext _context;
        public ProductComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofPost = (from p in _context.Slides
                              where (p.IsActive == true) && (p.Status == 1)
                              orderby p.SlideID descending
                              select p).Take(3).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", listofPost));
        }
    }
}
