using Proniam.Models;

namespace Proniam.ModelsVM
{
    public class HomeVM
    {
        public List<Products> Products { get; set; }
        public List<Slides> Slides { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<Categories> Categories { get; set; }
    }
}