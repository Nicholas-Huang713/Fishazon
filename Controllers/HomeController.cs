using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Fishazon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace Fishazon.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
     
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("registration")]
        public IActionResult Registration()
        {
            if(HttpContext.Session.GetInt32("id") != null)
            {
                return RedirectToAction("AllProducts");
            }
            return View("Registration");
        }

        [HttpGet("itemregistration")]
        public IActionResult ItemRegistration()
        {
            if(HttpContext.Session.GetInt32("id") != null)
            {
                return RedirectToAction("AllProducts");
            }
            ViewBag.Message = "You must have an account to add to the shopping cart";
            return View("Registration");
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            if(ModelState.IsValid)  
            {
                if(dbContext.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Registration");
                } 
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    user.Password = Hasher.HashPassword(user, user.Password);
                    dbContext.Add(user);
                    dbContext.SaveChanges();
                    var dbUser = dbContext.Users.FirstOrDefault(u => u.Email == user.Email);
                    HttpContext.Session.GetInt32("id");
                    HttpContext.Session.SetInt32("id", dbUser.UserId);
                    return RedirectToAction("AllProducts");
                }
            }
            else
            {
                return View("Registration");
            }
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View("Login");
        }

        [HttpPost("signin")]
        public IActionResult Signin(string Email, string Password)
        {
            var dbUser = dbContext.Users.FirstOrDefault(u => u.Email == Email);
            if(dbUser == null)
            {
                ViewBag.Error = "Email not registered";
                return View("Login");
            }
            else
            {
                var Hasher = new PasswordHasher<User>();
                if(0 != Hasher.VerifyHashedPassword(dbUser, dbUser.Password, Password)) {
                        HttpContext.Session.GetInt32("id");
                        HttpContext.Session.SetInt32("id", dbUser.UserId);
                        return RedirectToAction("AllProducts");
                    }
                    else {
                        ViewBag.Error = "Incorrect Password";
                        return View("Login");
                    }
            }
        }

        [HttpGet("allproducts")]
        public IActionResult AllProducts()
        {
            List<Product> AllRods = dbContext.Products.Where(p => p.Category == "rods").ToList();
            List<Product> AllLines = dbContext.Products.Where(p => p.Category == "lines").ToList();
            List<Product> AllReels = dbContext.Products.Where(p => p.Category == "reels").ToList();
            Order currentOrder = dbContext.Orders
                                .Include(u => u.CreatedItems)
                                .FirstOrDefault(o => o.UserId == HttpContext.Session.GetInt32("id") && o.Complete == false);
            List<String> productNames = new List<String>();
            if(currentOrder != null)
            {
                foreach(var item in currentOrder.CreatedItems)
                {
                    productNames.Add(item.ItemName);
                }
                ViewBag.Productnames = productNames;
                ViewBag.AllRods = AllRods;
                ViewBag.AllReels = AllReels;
                ViewBag.AllLines = AllLines;
                return View("AllProducts");
            }
            else 
            {
                ViewBag.Productnames = productNames;
                ViewBag.AllRods = AllRods;
                ViewBag.AllReels = AllReels;
                ViewBag.AllLines = AllLines;
                return View("AllProducts");
            }
            
        }       

        [HttpGet("rods")]
        public IActionResult Rods()
        {
            List<Product> AllRods = dbContext.Products.Where(p => p.Category == "rods").ToList();
            Order currentOrder = dbContext.Orders
                                .Include(u => u.CreatedItems)
                                .FirstOrDefault(o => o.UserId == HttpContext.Session.GetInt32("id") && o.Complete == false);
            List<String> productNames = new List<String>();
            if(currentOrder != null)
            {
                foreach(var item in currentOrder.CreatedItems)
                {
                    productNames.Add(item.ItemName);
                }
                ViewBag.Productnames = productNames;
                ViewBag.AllRods = AllRods;
                return View("rods");
            }
            else 
            {
                ViewBag.AllRods = AllRods;
                return View("rods");
            } 
        }

        [HttpGet("reels")]
        public IActionResult Reels()
        {
            List<Product> AllReels = dbContext.Products.Where(p => p.Category == "reels").ToList();
            Order currentOrder = dbContext.Orders
                                .Include(u => u.CreatedItems)
                                .FirstOrDefault(o => o.UserId == HttpContext.Session.GetInt32("id") && o.Complete == false);
            List<String> productNames = new List<String>();
            if(currentOrder != null)
            {
                foreach(var item in currentOrder.CreatedItems)
                {
                    productNames.Add(item.ItemName);
                }
                ViewBag.Productnames = productNames;
                ViewBag.AllReels = AllReels;
                return View("reels");
            }
            else 
            {
                ViewBag.AllReels = AllReels;
                return View("reels");
            } 
        }

        [HttpGet("lines")]
        public IActionResult Lines()
        {
            List<Product> AllLines = dbContext.Products.Where(p => p.Category == "lines").ToList();
            Order currentOrder = dbContext.Orders
                                .Include(u => u.CreatedItems)
                                .FirstOrDefault(o => o.UserId == HttpContext.Session.GetInt32("id") && o.Complete == false);
            List<String> productNames = new List<String>();
            if(currentOrder != null)
            {
                foreach(var item in currentOrder.CreatedItems)
                {
                    productNames.Add(item.ItemName);
                }
                ViewBag.Productnames = productNames;
                ViewBag.AllLines = AllLines;
                return View("Lines");
            }
            else 
            {
                ViewBag.AllLines = AllLines;
                return View("Lines");
            } 
            
        }

        [HttpGet("cart")]
        public IActionResult Cart()
        {
            if(HttpContext.Session.GetInt32("id")== null)
            {
                ViewBag.LoggedOutMessage = "Login or create an account to start adding to your shopping cart";
                return View("Cart");
            }
            User currentUser = dbContext.Users
                                .Include(u => u.CreatedOrders)
                                .FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("id"));
            List<Order> userOrders = dbContext.Orders
                                .Where(o => o.UserId == HttpContext.Session.GetInt32("id"))
                                .Include(o => o.CreatedItems)
                                .ToList();
            if(currentUser.CreatedOrders.Count == 0)
            {
                ViewBag.EmptyMessage = "Head over to the Products page to add items to your shopping cart";
                return View("Cart");
            }
            else 
            {
                foreach(var order in userOrders)
                {
                    if(order.Complete == false)
                    {
                        double sum = 0;
                        foreach(var item in order.CreatedItems)
                        {
                            sum += item.Price * item.Amount;
                        }
                        ViewBag.SubTotal = sum;
                        ViewBag.Total = sum + 8.59;
                        ViewBag.ItemList = order.CreatedItems;
                        ViewBag.Order = order;
                        return View("Cart");
                    }
                    else 
                    {
                        continue;
                    }
                }
                ViewBag.EmptyMessage = "Head over to the Products page to add items to your shopping cart";
                return View("Cart");
            }
        }

        [HttpGet("addcart/{productId}")]
        public IActionResult AddCart(int productId)
        {
            User currentUser = dbContext.Users
                                .Include(u => u.CreatedOrders)
                                .FirstOrDefault(u => u.UserId ==  HttpContext.Session.GetInt32("id"));
            Product currentProduct = dbContext.Products.FirstOrDefault(p => p.ProductId == productId);
            Order currentOrder = dbContext.Orders.FirstOrDefault(o => o.Complete == false);
            if(currentOrder == null){
                Order newOrder = new Order
                {
                    UserId = currentUser.UserId,
                    Creator = currentUser
                };
                currentUser.CreatedOrders.Add(newOrder);
                Item item = new Item 
                {
                    OrderId = newOrder.OrderId,
                    ItemName = currentProduct.Name,
                    Price = currentProduct.Price,
                    Img = currentProduct.Img, 
                    Order = newOrder
                }; 
                newOrder.CreatedItems.Add(item);
                dbContext.SaveChanges();
                return RedirectToAction("Cart");
            } 
            else 
            {
                Item newItem = new Item 
                {
                    OrderId = currentOrder.OrderId,
                    ItemName = currentProduct.Name,
                    Price = currentProduct.Price,
                    Img = currentProduct.Img,
                    Order = currentOrder
                };
                currentOrder.CreatedItems.Add(newItem);
                dbContext.SaveChanges();
                return RedirectToAction("Cart");
            }
        }

        [HttpGet("details/{itemId}")]
        public IActionResult Details(int itemId)
        {
            if(HttpContext.Session.GetInt32("id")== null)
            {
                return View("Index");
            }
            Item SelectedItem = dbContext.Items.SingleOrDefault(i => i.ItemId == itemId);
            ViewBag.Item = SelectedItem;
            return View("Details");
        }

        [HttpPost("update")]
        public IActionResult Update(int itemId, int NewAmount)
        {
            if(HttpContext.Session.GetInt32("id")== null)
            {
                return View("Index");
            }
            Item currentItem = dbContext.Items.SingleOrDefault(i => i.ItemId == itemId);
            currentItem.Amount = NewAmount;
            dbContext.SaveChanges();
            return RedirectToAction("Cart");
        }

        [HttpGet("delete/{itemId}")]
        public IActionResult Delete(int itemId)
        {
            if(HttpContext.Session.GetInt32("id")== null)
            {
                return View("Index");
            }
            Item itemToDelete = dbContext.Items.SingleOrDefault(i => i.ItemId == itemId);
            Order currentOrder = dbContext.Orders
                                    .Include(o => o.CreatedItems)
                                    .SingleOrDefault(o => o.OrderId == itemToDelete.OrderId);
            currentOrder.CreatedItems.Remove(itemToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Cart");
        }

        [HttpGet("placeorder")]
        public IActionResult PlaceOrder()
        {
            User CurrentUser = dbContext.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("id"));
            Order NewOrder = dbContext.Orders.SingleOrDefault(o => o.Complete == false);
            NewOrder.Complete = true;
            dbContext.SaveChanges();
            ViewBag.UserName = CurrentUser.FirstName;
            return View("Success");
        }

        [HttpGet("orders")]
        public IActionResult Orders()
        {
            User CurrentUser = dbContext.Users
                                .Include(u => u.CreatedOrders)    
                                .ThenInclude(o => o.CreatedItems)
                                .FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("id")); 
            List<Order> AllOrders = CurrentUser.CreatedOrders
                                    .OrderByDescending(o => o.CreatedAt)
                                    .ToList();
            ViewBag.AllOrders = AllOrders;
            ViewBag.CurrentUser = CurrentUser;
            return View("Orders");
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpPost("uploadproducts")]
        public void UploadProducts()
        {
            Product rod1 = new Product();
            rod1.Category = "rods";
            rod1.Name = "Shimano Spinning Rod";
            rod1.Price = 49.99;
            rod1.Img = "rod1.jpg";
            dbContext.Add(rod1);
        
            Product rod2 = new Product();
            rod2.Category = "rods";
            rod2.Name = "Quest Spin Series Rod";
            rod2.Price = 29.99;
            rod2.Img = "rod2.jpg";
            dbContext.Add(rod2);

            Product rod3 = new Product();
            rod3.Category = "rods";
            rod3.Name = "Zebco Spinning Rod";
            rod3.Price = 39.99;
            rod3.Img = "rod3.jpeg";
            dbContext.Add(rod3);

            Product rod4 = new Product();
            rod4.Category = "rods";
            rod4.Name = "Dock Demon Rod";
            rod4.Price = 49.99;
            rod4.Img = "rod4.jpg";
            dbContext.Add(rod4);

            Product reel1 = new Product();
            reel1.Category = "reels";
            reel1.Name = "Shimano Spinning Reel";
            reel1.Price = 35.99;
            reel1.Img = "reel3.jpg";
            dbContext.Add(reel1);

            Product reel2 = new Product();
            reel2.Category = "reels";
            reel2.Name = "Daiwa Spinning Reel";
            reel2.Price = 25.99;
            reel2.Img = "reel4.jpeg";
            dbContext.Add(reel2);

            Product reel3 = new Product();
            reel3.Category = "reels";
            reel3.Name = "Nine Plus Fly Reel";
            reel3.Price = 49.99;
            reel3.Img = "reel5.jpeg";
            dbContext.Add(reel3);

            Product reel4 = new Product();
            reel4.Category = "reels";
            reel4.Name = "Exist Spinning Reel";
            reel4.Price = 39.99;
            reel4.Img = "reel7.jpeg";
            dbContext.Add(reel4);

            Product line1 = new Product();
            line1.Category = "lines";
            line1.Name = "Stren High Impact Monofilament";
            line1.Price = 15.99;
            line1.Img = "line1.jpg";
            dbContext.Add(line1);

            Product line2 = new Product();
            line2.Category = "lines";
            line2.Name = "Dyneema Monofilament";
            line2.Price = 15.99;
            line2.Img = "line2.jpg";
            dbContext.Add(line2);

            Product line3 = new Product();
            line3.Category = "lines";
            line3.Name = "Trilene Flourocarbon";
            line3.Price = 21.99;
            line3.Img = "line3.jpg";
            dbContext.Add(line3);

            Product line4 = new Product();
            line4.Category = "lines";
            line4.Name = "SpiderWire Stealth-Blue Camo-Braid";
            line4.Price = 29.99;
            line4.Img = "line4.jpg";
            dbContext.Add(line4);
            dbContext.SaveChanges();

            Console.WriteLine("Uploaded");
        }
    }
}
