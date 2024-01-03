using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Chessinfo.Data;
using Chessinfo.Models;
using Chessinfo.Migrations;

namespace Chessinfo.Controllers
{
    public class PlayersController : Controller
    {
        private readonly ChessinfoContext _context;

        public List<Country> _countries;

        public PlayersController(ChessinfoContext context)
        {
            _context = context;

        }

        // GET: Players
       

        public async Task<IActionResult> Index(string searchString)
        {
            var players = from player in _context.Player select player;

            if (!String.IsNullOrEmpty(searchString))
            {
                players = players.Where(player => (player.FirstName.Contains(searchString) || player.LastName.Contains(searchString)));
            }

            return View(await players.Include(p => p.Country).Include(p => p.Title).OrderByDescending(p => p.classicalRating).ToListAsync());
        }
        // GET: Players/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var player = await _context.Player
                .FirstOrDefaultAsync(m => m.Id == id);
            if (player == null)
            {
                return NotFound();
            }

            return View(player);
        }

        // GET: Players/Create
        public IActionResult Create()
        {
            ViewBag.Countries = _context.Country.ToList();
            ViewBag.Titles = _context.Title.ToList();
            return View();
        }

        // POST: Players/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,DateTime, classicalRating, Country")] Player player)
        {
     
            player.Country = _context.Country?.FirstOrDefault(country => country.Id == player.Country.Id);

            if (ModelState.IsValid )
            {

                _context.Add(player);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(player);
        }

        // GET: Players/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {

            ViewBag.Countries = _context.Country.ToList();
            ViewBag.Titles = _context.Title?.ToList();
            if (id == null)
            {
                return NotFound();
            }

            var player = await _context.Player.FindAsync(id);
            
            if (player == null)
            {
                return NotFound();
            }
            return View(player);
        }

        // POST: Players/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,DateTime, classicalRating, Country, CountryId, TitleId")] Player player)
        {
            if (id != player.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //ViewBag.Countries = _context.Country.ToList();
                    
                    _context.Update(player);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlayerExists(player.Id))
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
            return View(player);
        }

        // GET: Players/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var player = await _context.Player
                .FirstOrDefaultAsync(m => m.Id == id);
            if (player == null)
            {
                return NotFound();
            }

            return View(player);
        }

        // POST: Players/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var player = await _context.Player.FindAsync(id);
            if (player != null)
            {
                _context.Player.Remove(player);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlayerExists(int id)
        {
            return _context.Player.Any(e => e.Id == id);
        }
    }
}
