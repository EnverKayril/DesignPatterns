using Microsoft.AspNetCore.Mvc.Rendering;
using RepositoryDesignPattern.EntityLayer.Concrete;

namespace DesignPattern.Repository.Models
{
    public class UpdateProductViewModel
    {
        public Product Product { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; }
    }
}
