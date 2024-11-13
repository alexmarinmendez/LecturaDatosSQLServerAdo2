using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Dao;

namespace WebApplication1.Controllers
{
    public class CustomersController : Controller
    {
        CustomersDao customersDao = new CustomersDao();
        // GET: Customers
        public ActionResult ListadoCustomers()
        {
            var listado = customersDao.ListarCustomers();
            return View(listado); 
        }
    }
}