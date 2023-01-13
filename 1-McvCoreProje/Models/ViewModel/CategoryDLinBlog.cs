using Microsoft.AspNetCore.Mvc.Rendering;

namespace AMvcCoreProjeKampi.Models.ViewModel
{
    public class CategoryDLinBlog
    {
        public string SelcetedCategory { get; set; }
        public List<SelectListItem> CategorySelectList { get; set; }

    }
}
