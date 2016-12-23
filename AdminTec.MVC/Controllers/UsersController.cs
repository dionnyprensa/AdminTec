using AdminTec.Application.Interfaces;
using AdminTec.MVC.Models;
using System;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AdminTec.MVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUser UserService;

        public UsersController(IUser userService)
        {
            UserService = userService;
        }

        // GET: Users
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserViewModel m, string ReturnUrl = "")
        {
            var user = UserService.SignIn(m.UserName, m.Password);

            if (user != null)
            {
                FormsAuthenticationTicket Ticket = new
                    FormsAuthenticationTicket(1, m.UserName, DateTime.Now, DateTime.Now.AddMinutes(30), true, m.UserName);

                var EncrypTicket = FormsAuthentication.Encrypt(Ticket);

                var AuthCookie = new HttpCookie(FormsAuthentication.FormsCookieName, EncrypTicket);

                if (m.RememberMe)
                    AuthCookie.Expires = Ticket.Expiration;

                Response.Cookies.Add(AuthCookie);

                if (Url.IsLocalUrl(ReturnUrl))
                    return Redirect(ReturnUrl);
                else
                    return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.Remove("Password");
                ModelState.AddModelError(string.Empty, "Usuario o Clave incorrecta");
                return View();
            }
        }

        public async Task<ActionResult> LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}