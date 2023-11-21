using Microsoft.AspNetCore.SignalR;
using SıgnalRProject.Service.Services.Abstract;

namespace SıgnalRProject.API.Hubs
{
    public class SignalRHub : Hub
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly IMoneyCaseService _moneyCaseService;
        private readonly IMenuTableService _menuTableService;
        private readonly IBookingService _bookingService;
        private readonly INotificationService _notificationService;
        public SignalRHub(ICategoryService categoryService, IProductService productService, IOrderService orderService, IMoneyCaseService moneyCaseService, IMenuTableService menuTableService, IBookingService bookingService, INotificationService notificationService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _orderService = orderService;
            _moneyCaseService = moneyCaseService;
            _menuTableService = menuTableService;
            _bookingService = bookingService;
            _notificationService = notificationService;
        }
        public async Task SendStatistic()
        {
            var value =await _categoryService.CategoryCount();
            await Clients.All.SendAsync("ReceiveCategoryCount", value);

            var value2 = await _productService.ProductCount();
            await Clients.All.SendAsync("ReceiveProductCount", value2);

            var value3 = await _categoryService.ActiveCategoryCount();
            await Clients.All.SendAsync("ReceiveActiveCategoryCount", value3);

            var value4 = await _categoryService.PassiveCategoryCount();
            await Clients.All.SendAsync("ReceivePassiveCategoryCount", value4);

            var value5 = await _productService.ProductCountByCategoryNameHamburger();
            await Clients.All.SendAsync("ReceiveProductCountByCategoryNameHamburger", value5);

            var value7 = await _productService.ProductPriceAvg();
            await Clients.All.SendAsync("ReceiveProductPriceAvg", value7.ToString("0.00") + "₺");

            var value6 = await _productService.ProductCountByCategoryNameDrink();
            await Clients.All.SendAsync("ReceiveProductCountByCategoryNameDrink", value6);

            var value8 = await _productService.ProductNameByMaxPrice();
            await Clients.All.SendAsync("ReceiveProductNameByMaxPrice", value8);

            var value9 =await  _productService.ProductNameByMinPrice();
            await Clients.All.SendAsync("ReceiveProductNameByMinPrice", value9);

            var value10 = await _productService.ProductAvgPriceByHamburger();
            await Clients.All.SendAsync("ReceiveProductAvgPriceByHamburger", value10.ToString("0.00") + "₺");

            //var value11 = await _orderService.TotalOrderCount();
            //await Clients.All.SendAsync("ReceiveTotalOrderCount", value11);

            //var value12 = await _orderService.ActiveOrderCount();
            //await Clients.All.SendAsync("ReceiveActiveOrderCount", value12);

            //var value13 = await _orderService.LastOrderPrice();
            //await Clients.All.SendAsync("ReceiveLastOrderPrice", value13.ToString("0.00") + "₺");

            //var value14 = await _moneyCaseService.TotalMoneyCaseAmount();
            //await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", value14.ToString("0.00") + "₺");

            //var value16 = await _menuTableService.MenuTableCount();
            //await Clients.All.SendAsync("ReceiveMenuTableCount", value16);


            

        }
    }
}
