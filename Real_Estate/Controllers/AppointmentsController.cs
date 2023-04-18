﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Real_Estate.Data;
using Real_Estate.Models;
using Real_Estate.ViewModels;

namespace Real_Estate.Controllers
{
    public class AppointmentsController : Controller
    {
        private readonly RealEDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public AppointmentsController(RealEDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
           _userManager = userManager;
        }
        public async Task<IActionResult> AppointmentAdmin()
        {
            var properties = await this._context.EstateProperties.Select(p => new EstateProperty
            {
                Id = p.Id,
                Name = p.Name
                
            }).ToListAsync();
            var viewmodel = new AppointmentViewModel
            {
                Events = _context.Appointments.Select(x => new AppointmentViewModel.EventModel
                {
                    Title = x.Name,
                    Start = x.DateofAppointment.ToString() ?? ""
                }).ToList(),
            };

            ViewData["PropertyId"] = new SelectList(properties, "Id", "Name");
            return View(viewmodel);
        }
        public async Task<IActionResult> Appointment()
        {
          var properties = await this._context.EstateProperties.Select(p => new EstateProperty
          {
              Id = p.Id,
              Name = p.Name
          }).ToListAsync();
            var viewmodel = new AppointmentViewModel
            {
                Events = _context.Appointments.Select(x => new AppointmentViewModel.EventModel
                {
                    Title = x.Name,
                    Start = x.DateofAppointment.ToString() ?? ""
                }).ToList(),
            };

            ViewData["PropertyId"] = new SelectList(properties, "Id", "Name" );
            return View(viewmodel);
        }
        public async Task<IActionResult> AppointmentList()
        {

            var realEstateDbContext = _context.Appointments.Include(a => a.Property);
            return View(await realEstateDbContext.ToListAsync());
        }


        // GET: Appointments

        public async Task<IActionResult> Index()
        {
            if (User.IsInRole("Owner"))
            {
                var user = await _userManager.GetUserAsync(User);
                var ownerAppointments = await _userManager.Users
                    .Where(a => a.Id == user.Id)
                    .Include(a => a.Appointments)
                    .FirstOrDefaultAsync();

                var viewModel = new AppointmentUserViewModel
                {
                    User = ownerAppointments,
                    Appointments = ownerAppointments.Appointments.ToList()
                };

                return View(viewModel);
            }

            var appointments = await _context.Appointments.ToListAsync();
            var allViewModel = new AppointmentUserViewModel
            {
                Appointments = appointments
            };

            return View(allViewModel);
        }


        // GET: Appointments/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null || _context.Appointments == null)
            {
                return NotFound();
            }

            var appointment = await _context.Appointments
                .Include(a => a.Property)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appointment == null)
            {
                return NotFound();
            }

            return View(appointment);
        }

        // GET: Appointments/Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["PropertyId"] = new SelectList(_context.EstateProperties, "Id", "Name");
            return View();
        }

        // POST: Appointments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,Phone,Address,PropertyId,DateofAppointment")] Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                EstateProperty estateProperty = await _context.EstateProperties
                    .Where(a => a.Id == appointment.PropertyId).FirstOrDefaultAsync();
                appointment.OwnerId = estateProperty.ApplicationUserId;
                _context.Add(appointment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PropertyId"] = new SelectList(_context.EstateProperties, "Id", "Name", appointment.PropertyId);
            return View("Create", appointment);
        }

        // GET: Appointments/Create
        public IActionResult Createadm()
        {
           
            ViewData["PropertyId"] = new SelectList(_context.EstateProperties, "Id", "Name");
            return View();
        }

        // POST: Appointments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Createadm([Bind("Id,Name,Email,Phone,Address,PropertyId,DateofAppointment")] Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appointment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(AppointmentList));
            }
            ViewData["PropertyId"] = new SelectList(_context.EstateProperties, "Id", "Name", appointment.PropertyId);
            return View(appointment);
        }

        // GET: Appointments/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null || _context.Appointments == null)
            {
                return NotFound();
            }

            var appointment = await _context.Appointments.FindAsync(id);
            if (appointment == null)
            {
                return NotFound();
            }
            ViewData["PropertyId"] = new SelectList(_context.EstateProperties, "Id", "Name", appointment.PropertyId);
            return View(appointment);
        }

        // POST: Appointments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,Phone,Address,PropertyId,DateofAppointment")] Appointment appointment)
        {
            if (id != appointment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appointment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppointmentExists(appointment.Id))
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
            ViewData["PropertyId"] = new SelectList(_context.EstateProperties, "Id", "Name", appointment.PropertyId);
            return View(appointment);
        }

        // GET: Appointments/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null || _context.Appointments == null)
            {
                return NotFound();
            }

            var appointment = await _context.Appointments
                .Include(a => a.Property)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appointment == null)
            {
                return NotFound();
            }

            return View(appointment);
        }

        // POST: Appointments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Appointments == null)
            {
                return Problem("Entity set 'RealEstateDbContext.Appointment'  is null.");
            }
            var appointment = await _context.Appointments.FindAsync(id);
            if (appointment != null)
            {
                _context.Appointments.Remove(appointment);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppointmentExists(int id)
        {
          return (_context.Appointments?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
