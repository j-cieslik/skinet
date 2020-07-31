using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithTypesAndBrandsSPecification : BaseSpecification<Product>
    {
        public ProductsWithTypesAndBrandsSPecification()
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }
    }
}