using ShopOnline.Models.Dtos;

namespace ShopOnline.Web.Services.Contract
{
    public interface IManageProductsLocalStorageService
    {
        Task<IEnumerable<ProductDto>> GetCollection();

        Task RemoveCollection();
    }
}
