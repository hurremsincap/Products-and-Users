using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using KafeinCase.Business.Abstract;
using KafeinCase.MvcUI.Models.ViewModels;
using KafeinCase.Entities.ComplexTypes;
using KafeinCase.Entities.Concrete;

namespace KafeinCase.MvcUI.Controllers
{
    public class HomeController : Controller
    {

        private IUsersService _usersService;
        private IProductsService _productsService;
        private IUserProductService _userProductService;


        public HomeController(IUsersService usersService, IProductsService productsService, IUserProductService userProductService)
        {
            _usersService = usersService;
            _productsService = productsService;
            _userProductService = userProductService;

        }

        // GET: Home
        public ActionResult Index()
        {
            //kullanıcı ve ürünleri listeleme
            ViewBag.Users = _usersService.GetAll();
            ViewBag.Products = _productsService.GetAll();
            return View();
        }

        public ActionResult AddUserProduct(Users userid, List<Products> productid)
        {
            //seçilen kullanıcı ve ürünleri database kaydetmek için çağrışan işlemler
            try
            {      
            UserProduct userProduct = new UserProduct();
            userProduct.UserId = userid.UserId;
            foreach(var items in productid)
            {
                userProduct.ProductId = items.ProductId;
                _userProductService.AddUserProduct(userProduct);
            }
                return Json(true);
            }
            catch(InvalidCastException e)
            {
                return Json(false);
            }
            
        }

    }
}