using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UploadSales.Data;
using UploadSales.Models;

namespace UploadSales.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(DateTime fromDate, DateTime toDate)// kludgy code. don't read too closely
        {
            ViewData["fdate"] = fromDate;
            ViewData["tdate"]  = toDate;
            var SalesColl = _context.Sales.ToList<Sale>();
            if(SalesColl.Count<Sale>() > 0)
            {
                DateTime test = SalesColl.Min(x => x.OrderDate);
                DateTime test2 = SalesColl.Max(x => x.OrderDate);
                if ((fromDate >= SalesColl.Min(x => x.OrderDate)) && (toDate <= SalesColl.Max(x => x.OrderDate)))
                {
                    var MySummary = from s in SalesColl.AsEnumerable<Sale>()
                        where s.OrderDate >= fromDate && s.OrderDate <= toDate
                                    group s by s.ItemType into GroupOne
                                    select new { item = GroupOne.Key, Total_Profit = GroupOne.Sum(x => x.TotalProfit) };
                    List<Summary> Datasource = new List<Summary>();
                    foreach(var item in MySummary.AsEnumerable())
                    {
                        Summary s = new Summary();
                        s.ItemName = item.item;
                        s.TotalProfits = item.Total_Profit;
                        Datasource.Add(s);
                    }
                    var sortedList = (from rec in Datasource.AsEnumerable()
                        orderby rec.TotalProfits descending
                        select rec).Take<Summary>(5);
                    return View(sortedList);
                } 
                else
                {
                    var MySummary = from s in SalesColl.AsEnumerable<Sale>()
                                    group s by s.ItemType into GroupOne
                                    select new { item = GroupOne.Key, Total_Profit = GroupOne.Sum(x => x.TotalProfit) };
                    List<Summary> Datasource = new List<Summary>();
                    foreach(var item in MySummary.AsEnumerable())
                    {
                        Summary s = new Summary();
                        s.ItemName = item.item;
                        s.TotalProfits = item.Total_Profit;
                        Datasource.Add(s);
                    }
                    var sortedList = (from rec in Datasource.AsEnumerable()
                        orderby rec.TotalProfits descending
                        select rec).Take<Summary>(5);
                    return View(sortedList);
                }
            } 
            else
            {
                List<Summary> EmptyList = new List<Summary>();
                return View(EmptyList);
            }
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
