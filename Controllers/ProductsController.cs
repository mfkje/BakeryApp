using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BakeryApp.Data;
using BakeryApp.Models;
using System.Collections;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using System.Dynamic;

namespace BakeryApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index(long? id = -1)
        {
            if (id == -1)
            {
                
                    var model = new IndexViewModel();
                    model.Products = await _context.Products.ToListAsync();
                    model.Categories = await _context.Categories.ToListAsync();

                return _context.Products != null ?
                        View(model) :
                        Problem("Entity set 'ApplicationDbContext.Products'  is null.");
            }
            else
            {

                var categoryexist = _context.Categories.Any(x => x.ID == id);

                if (categoryexist)
                {

                    var products = from p in _context.Products
                                    where p.Category.ID > id
                                    select p;

                    var model = new IndexViewModel();
                    model.Products = await _context.Products.Where(x => x.Category.ID == id).ToListAsync();
                    model.Categories = await _context.Categories.ToListAsync();

                    return products != null ?
                        View(model) :
                            Problem("Entity set 'ApplicationDbContext.Products'  is null.");
                }
                else
                {
                    return RedirectToAction("Index", new { id = -1 });
                }
            }
        }


        // GET: Products/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.ID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Create()
        {

            var model = new ProductCategoriesVM();
            model.Product = new Product();
            model.Categories = await _context.Categories.ToListAsync();

            return View(model);
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "admin")]
        [HttpPost]
        //public async Task<IActionResult> Create([Bind("Name,Description,CategoryID,Image,Price")] Product product)
        public async Task<IActionResult> Create(IFormCollection collection)
        {
            Product product = new Product()
            {
                Name = collection["Product.Name"],
                Description = collection["Product.Description"],
                CategoryID = (long)Convert.ToInt64(collection["CategoryID"]),
                Image = collection["Product.Image"],
                Price = Convert.ToDecimal(collection["Product.Price"]),
            };

            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(product);
        }

        // GET: Products/Edit/5
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("ID,Name,Description,Image,Price")] Product product)
        {
            if (id != product.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Delete/5
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.ID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [Authorize(Roles = "admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.Products == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Products'  is null.");
            }
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(long id)
        {
          return (_context.Products?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
