using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BakeryApp.Data;
using BakeryApp.Models;
using Microsoft.AspNetCore.Identity;

namespace BakeryApp.Controllers
{
    public class CartsController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly UserManager<ApplicationUser> _userManager;
        public CartsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Carts
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            var userId = user?.Id;

            var applicationDbContext = _context.Carts.Where(c => c.ApplicationUserId.Equals(userId)).Include(c => c.ApplicationUser).Include(c => c.Product);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Carts/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Carts == null)
            {
                return NotFound();
            }

            var cart = await _context.Carts
                .Include(c => c.ApplicationUser)
                .Include(c => c.Product)
                .FirstOrDefaultAsync(m => m.ApplicationUserId == id);
            if (cart == null)
            {
                return NotFound();
            }

            return View(cart);
        }

        // GET: Carts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Carts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("ApplicationUserId,ProductID,Quantity")] Cart cart)
        {

            var fetchedCart = await _context.Carts.FindAsync(cart.ApplicationUserId, cart.ProductID);
            if (fetchedCart != null)
            {
                TempData["qty"] = cart.Quantity;
                fetchedCart.Quantity += cart.Quantity;
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Products", new {ID = cart.ProductID}); 
            }


            _context.Add(cart);
            await _context.SaveChangesAsync();

            if (ModelState.IsValid)
            {
                _context.Add(cart);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "Id", cart.ApplicationUserId);
            ViewData["ProductID"] = new SelectList(_context.Products, "ID", "ID", cart.ProductID);
            return View(cart);
        }

        // GET: Carts/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Carts == null)
            {
                return NotFound();
            }

            var cart = await _context.Carts.FindAsync(id);
            if (cart == null)
            {
                return NotFound();
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "Id", cart.ApplicationUserId);
            ViewData["ProductID"] = new SelectList(_context.Products, "ID", "ID", cart.ProductID);
            return View(cart);
        }

        // POST: Carts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        
        public async Task<IActionResult> Edit([Bind("ApplicationUserId,ProductID,Quantity")] Cart cart)
        {
            //if (id != cart.ApplicationUserId)
            //{
            //    return NotFound();
            //}

            if (cart.Quantity <= 0)
            {
                DeleteConfirmed(cart.ApplicationUserId, cart.ProductID);
            }

            //if (ModelState.IsValid)
            //{
                try
                {
                    _context.Update(cart);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartExists(cart.ApplicationUserId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            //}
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "Id", cart.ApplicationUserId);
            ViewData["ProductID"] = new SelectList(_context.Products, "ID", "Description", cart.ProductID);
            return View(cart);
        }

        // GET: Carts/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Carts == null)
            {
                return NotFound();
            }

            var cart = await _context.Carts
                .Include(c => c.ApplicationUser)
                .Include(c => c.Product)
                .FirstOrDefaultAsync(m => m.ApplicationUserId == id);
            if (cart == null)
            {
                return NotFound();
            }

            return View(cart);
        }

        // POST: Carts/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(String ApplicationUserId, long ProductID)
        {
            if (_context.Carts == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Carts'  is null.");
            }


            var cart = await _context.Carts.FindAsync(ApplicationUserId, ProductID);
            if (cart != null)
            {
                _context.Carts.Remove(cart);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartExists(string id)
        {
          return (_context.Carts?.Any(e => e.ApplicationUserId == id)).GetValueOrDefault();
        }
    }
}
