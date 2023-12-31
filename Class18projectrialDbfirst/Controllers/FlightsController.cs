﻿using Class18projectrialDbfirst.FltRepo;
using Class18projectrialDbfirst.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Class18projectrialDbfirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private readonly IFltRepo _repository;
        public FlightsController(IFltRepo repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Flight>>> GetFlights()
        {
            return await _repository.GetFlights();

        }
        [HttpPost]
        public async Task<ActionResult<Flight>> PostFlights(Flight flight)
        {
            return await _repository.PostFlights(flight);
        }
        [HttpPut]
        public async Task<ActionResult<Flight>> PutFlights(Flight flight)
        {
            return await _repository.PutFlights(flight);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Flight>> DeleteFlights(int id)
        {
            try
            {
                return await _repository.DeleteFlights(id);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }
    }
}
