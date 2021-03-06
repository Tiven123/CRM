using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcCRM.Models;

namespace MvcCRM.Controllers {
        public class UserController : Controller {
            private readonly MvcCRMContext _context;

            public UserController (MvcCRMContext context) {
                _context = context;
            }

            // GET: User
            public async Task<IActionResult> Index () {
                return View (await _context.User.ToListAsync ());
            }

            // GET: User/Details/5
            public async Task<IActionResult> Details (int? id) {
                if (id == null) {
                    return NotFound ();
                }

                var user = await _context.User
                    .SingleOrDefaultAsync (m => m.ID == id);
                if (user == null) {
                    return NotFound ();
                }

                return View (user);
            }

            // GET: User/Create
            public IActionResult Create () {
                return View ();
            }

            // POST: User/Create
            // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
            // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create ([Bind ("ID,Name,LastName,email,password,role")] User user) {
                if (ModelState.IsValid) {
                    _context.Add (user);
                    await _context.SaveChangesAsync ();
                    return RedirectToAction (nameof (Index));
                }
                return View (user);
            }

            // GET: User/Edit/5
            public async Task<IActionResult> Edit (int? id) {
                if (id == null) {
                    return NotFound ();
                }

                var user = await _context.User.SingleOrDefaultAsync (m => m.ID == id);
                if (user == null) {
                    return NotFound ();
                }
                return View (user);
            }

            // POST: User/Edit/5
            // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
            // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit (int id, [Bind ("ID,Name,LastName,email,password,role")] User user) {
                if (id != user.ID) {
                    return NotFound ();
                }

                if (ModelState.IsValid) {
                    try {
                        _context.Update (user);
                        await _context.SaveChangesAsync ();
                    } catch (DbUpdateConcurrencyException) {
                        if (!UserExists (user.ID)) {
                            return NotFound ();
                        } else {
                            throw;
                        }
                    }
                    return RedirectToAction (nameof (Index));
                }
                return View (user);
            }

            // GET: User/Delete/5
            public async Task<IActionResult> Delete (int? id) {
                if (id == null) {
                    return NotFound ();
                }

                var user = await _context.User
                    .SingleOrDefaultAsync (m => m.ID == id);
                if (user == null) {
                    return NotFound ();
                }

                return View (user);
            }

            // POST: User/Delete/5
            [HttpPost, ActionName ("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed (int id) {
                var user = await _context.User.SingleOrDefaultAsync (m => m.ID == id);
                _context.User.Remove (user);
                await _context.SaveChangesAsync ();
                return RedirectToAction (nameof (Index));
            }

            private bool UserExists (int id) {
                return _context.User.Any (e => e.ID == id);
            }

            private bool EmailExists (string emailN) {
                return _context.User.Any (e => e.email == emailN);
            }

            public IActionResult Login () {
                return View ();
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Authenticate (string email, string password) {
                if (!EmailExists (email)) {
                        return NotFound ();
                    }

                    if (ModelState.IsValid) {
                        try {
                            var user = from m in _context.User
                            select m;

                            if (!String.IsNullOrEmpty (email)) {
                                user = user.Where (s => s.Title.Contains (email));
                                if (!String.IsNullOrEmpty (password)) {
                                    user = user.Where (p => p.Title.Contains (password));
                                }
                            }

                            return View (await user.ToListAsync ();
                        } catch (DbUpdateConcurrencyException) {
                            if (!EmailExists (email)) {
                                return NotFound ();
                            } else {
                                throw;
                            }
                        }
                        return RedirectToAction (nameof (Index));
                    }
                    return View (user);

                }
            }
        }