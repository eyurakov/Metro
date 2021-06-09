using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Metro.Models.DB;
using System.Data.Entity;
using Metro.Dtos;
using Metro.Models;

namespace Metro.Controllers.Api
{
    public class HumansController : ApiController
    {
        private readonly MetroContext _context;

        
        public HumansController()
        {
            _context = new MetroContext();
        }

        //GET /api/customers
        public IHttpActionResult GetCustomers(string query = null)
        {
            var humansQuery = _context.Human
                .Include(c => c.Position);
            if (!string.IsNullOrWhiteSpace(query))
            {
                humansQuery = humansQuery.Where(c => c.FirstName.Contains(query));
            }
            var humanDtos = humansQuery
                .ToList().Select(Mapper.Map<Human, HumanDto>);
            return Ok(humanDtos);
        }

        //DELETE /api/customers/1
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var humanInDb = _context.Human.SingleOrDefault(c => c.Id == id);
            if (humanInDb == null)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Human.Remove(humanInDb);
            _context.SaveChanges();
        }
    }
}
