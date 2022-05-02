using ShopOnline.Models.Dtos;

namespace ShopOnline.Web.Services.Contract
{
    public interface IShoppingCartService
    {

        Task<IEnumerable<CartItemDto>> GetItems(int userId);

        Task<CartItemDto> AddItem(CartIteamToAddDto cartIteamToAddDto);

    }
}
