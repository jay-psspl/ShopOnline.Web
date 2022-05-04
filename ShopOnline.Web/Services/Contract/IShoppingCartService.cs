using ShopOnline.Models.Dtos;

namespace ShopOnline.Web.Services.Contract
{
    public interface IShoppingCartService
    {

        Task<List<CartItemDto>> GetItems(int userId);

        Task<CartItemDto> AddItem(CartIteamToAddDto cartIteamToAddDto);

        Task<CartItemDto> DeleteItem(int id);

    }
}
