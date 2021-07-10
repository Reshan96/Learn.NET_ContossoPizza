using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ContosoPizza.Models;
using ContosoPizza.Services;

namespace ContosoPizza.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        public PizzaController()
        {
        }

        // GET all action
        [HttpGet]
        public ActionResult<List<Pizza>> GetAll() => 
            PizzaService.GetAll();
        
        // GET by Id action
        [HttpGet("{id}")]
        public ActionResult<Pizza> Get(int id){
            var pizza = PizzaService.Get(id);
            
            if(pizza == null)
                return NotFound();
           
            return pizza;
        }

        // POST action
        [HttpPost]
        public IActionResult Create(Pizza pizza){
            PizzaService.Add(pizza);

            return CreatedAtAction(nameof(Create),new {id = pizza.Id},pizza);
            // The first parameter in the CreatedAtAction method call represents an action name. 
            // The nameof keyword is used to avoid hard-coding the action name.
            // CreatedAtAction uses the action name to generate a location HTTP response header with a URL to 
            //      the newly created pizza, as explained in the previous unit.
        }

        // PUT action
        [HttpPut("{id}")]
        public IActionResult Update(int id, Pizza pizza){
            if(id != pizza.Id)
                return BadRequest();
            
            var existingPizza = PizzaService.Get(id);
            if( existingPizza is null)
                return NotFound();

            PizzaService.Update(pizza);

            return NoContent();
        }

        // DELETE action
        [HttpDelete("{id}")]
        public IActionResult delete(int id){
            if(PizzaService.Get(id) is null)
                return NotFound();
            
            PizzaService.Delete(id);

            return NoContent();
        }
    }
}