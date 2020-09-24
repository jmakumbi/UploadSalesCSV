using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FileHelpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UploadSales.Data;
using UploadSales.Models;

namespace UploadSales.Controllers
{
    public class SalesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SalesController(ApplicationDbContext context) { _context = context; }

        // GET: Sales
        public async Task<IActionResult> Index() { return View(await _context.Sales.ToListAsync()); }

        // GET: Sales/Create
        public async Task<IActionResult> Create()
        {
            var MySettings = new DirectoryInfo(@"C:\uploads\"); //code smell shouldn't hardcode this but I am in a hurry
            var MyFiles = MySettings.GetFiles();

            //find each file
            foreach(FileInfo fi in MyFiles.AsEnumerable<FileInfo>()) //forgot to check for duplicate data
            {
                var S = GetSales(fi);
                //find each data row
                foreach(var r in S.AsEnumerable<SalesDataImporter>())
                {
                    Sale NewSale = new Sale();
                    NewSale.Id = Guid.NewGuid();
                    NewSale.ItemType = r.ItemType;
                    NewSale.OrderDate = DateTime.ParseExact(r.OrderDate, "m/d/yyyy", null);
                    NewSale.OrderPriority = r.OrderPriority;
                    NewSale.TotalCost = r.TotalCost;
                    NewSale.TotalRevenue = r.TotalRevenue;
                    NewSale.UnitPrice = r.UnitPrice;
                    NewSale.UnitsSold = r.UnitsSold;
                    NewSale.TotalProfit = r.TotalProfit;
                    _context.Add<Sale>(NewSale);
                }
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        //Get the records from the file in uploads folder
        private static SalesDataImporter[] GetSales(FileInfo f)
        {
            var engine = new FileHelperEngine<SalesDataImporter>();
            var l = engine.ReadFile(f.FullName);
            return l;
        }
    }
}
