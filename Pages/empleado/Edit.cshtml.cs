﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using practicaEmpleado.Data;
using practicaEmpleado.Modelo;

namespace practicaEmpleado.Pages.empleado
{
    public class EditModel : PageModel
    {
        private readonly practicaEmpleado.Data.practicaEmpleadoContext _context;

        public EditModel(practicaEmpleado.Data.practicaEmpleadoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Empleado Empleado { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Empleado == null)
            {
                return NotFound();
            }

            var empleado =  await _context.Empleado.FirstOrDefaultAsync(m => m.ID == id);
            if (empleado == null)
            {
                return NotFound();
            }
            Empleado = empleado;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Empleado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpleadoExists(Empleado.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EmpleadoExists(int id)
        {
          return (_context.Empleado?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
