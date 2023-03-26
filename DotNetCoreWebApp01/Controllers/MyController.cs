using Microsoft.AspNetCore.Mvc;
using WebApp01.Models;

namespace WebApp01.Controllers
{
    public class MyController : Controller
    {
        public void Index()
        {
            Core01Context obj = new Core01Context();
            var Clients = obj.Clients.ToList();
            var Workers = obj.Workers.ToList();
            var Customers = obj.Customers.ToList();
          
        }
    }
}
