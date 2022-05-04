using Microsoft.AspNetCore.Components;
using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contract;

namespace ShopOnline.Web.Pages.ComponentClass
{
    public class ProductDetailsBase : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }

        [Inject]
        public IProductService ProductService { get; set; }

        [Inject]
        public IShoppingCartService ShoppingCartService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }


        public ProductDto Product { get; set; }


        public string ErrorMessage { get; set; }


        protected override async Task OnInitializedAsync()
        {
            try
            {
                Product = await ProductService.GetItem(Id);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }

        protected async Task AddToCart_Click(CartIteamToAddDto cartIteamToAddDto)
        {
            try
            {
                var cartItemDto = await ShoppingCartService.AddItem(cartIteamToAddDto);
                NavigationManager.NavigateTo("/ShoppingCart"); 
            }
            catch (Exception)
            {
                //Log Exception
                throw;
            }
        }
    }
}
