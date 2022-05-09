using ShopOnline.Models.Dtos;

namespace ShopOnline.Web.Services.Contract
{
    public interface IManageCartItemsLocalStorageService
    {
        Task<List<CartItemDto>> GetCollection();

        Task SaveCollection(List<CartItemDto> cartItems);

        Task RemoveCollection();
    }
}
