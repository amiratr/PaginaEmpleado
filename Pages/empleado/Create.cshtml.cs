﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using practicaEmpleado.Data;
using practicaEmpleado.Modelo;

namespace practicaEmpleado.Pages.empleado
{
    public class CreateModel : PageModel
    {
        private readonly practicaEmpleado.Data.practicaEmpleadoContext _context;

        public CreateModel(practicaEmpleado.Data.practicaEmpleadoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Empleado Empleado { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Empleado == null || Empleado == null)
            {
                return Page();
            }

            _context.Empleado.Add(Empleado);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
