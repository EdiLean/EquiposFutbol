﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EquiposFutbol.Modelos;

namespace EquiposFutbol.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JugadoresController : ControllerBase
    {
        private readonly DataContext _context;

        public JugadoresController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Jugadores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Jugador>>> GetJugador()
        {
          if (_context.Jugador == null)
          {
              return NotFound();
          }
            return await _context.Jugador.Include(e=> e.equipo).ToListAsync();
        }

        // GET: api/Jugadores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Jugador>> GetJugador(int id)
        {
          if (_context.Jugador == null)
          {
              return NotFound();
          }
            var jugador = await _context.Jugador.FindAsync(id);

            if (jugador == null)
            {
                return NotFound();
            }

            return jugador;
        }

        // PUT: api/Jugadores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJugador(int id, Jugador jugador)
        {
            if (id != jugador.Id)
            {
                return BadRequest();
            }

            _context.Entry(jugador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JugadorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Jugadores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Jugador>> PostJugador(Jugador jugador)
        {
          if (_context.Jugador == null)
          {
              return Problem("Entity set 'DataContext.Jugador'  is null.");
          }
            _context.Jugador.Add(jugador);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJugador", new { id = jugador.Id }, jugador);
        }

        // DELETE: api/Jugadores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJugador(int id)
        {
            if (_context.Jugador == null)
            {
                return NotFound();
            }
            var jugador = await _context.Jugador.FindAsync(id);
            if (jugador == null)
            {
                return NotFound();
            }

            _context.Jugador.Remove(jugador);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JugadorExists(int id)
        {
            return (_context.Jugador?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
