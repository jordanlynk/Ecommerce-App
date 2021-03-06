using ECommerce_App.Auth.Services.Interfaces;
using ECommerce_App.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce_App.Controllers
{
    public class MealController : Controller
    {
        private readonly IMeal _meal;


        public MealController(IMeal meal)
        {
            _meal = meal;
        }
        
       
        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Meal>>> GetMeals()
        {
            await _meal.GetMeals();

            var meal = new List<Meal>()
            {
                
            };

            

            return View(meal);
        }

    [AllowAnonymous]
    [HttpGet("{id}")]
    public async Task<ActionResult<Meal>> GetMeal(int Id)
    {
      Meal meal = await _meal.GetMeal(Id);

      return meal;
    }

    [Authorize(Roles = "editor")]
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateMeal(int Id, Meal meal)
    {
      if (Id != meal.Id)
      {
        return BadRequest();
      }

      var upDatedMeal = await _meal.UpdateMeal(meal);

      return Ok(upDatedMeal);
    }
   
    public IActionResult UpdateMeal()
        {
            

            return View();
        }
        
        
        
    public IActionResult CreateMeal()
    {
      return View();
    }

    // [Authorize(Roles = "administrator")]
    [HttpPost]
    public async Task<ActionResult<Meal>> CreateMeal(Meal meal)
    {

      await _meal.CreateMeal(meal);
      if(!ModelState.IsValid)
      {
                
      return RedirectToAction("Meal/CreateMeal");
      }
      return View();
    }

    [Authorize(Roles = "Administrator")]
    [HttpDelete("{id}")]
    public async Task<ActionResult<Meal>> DeleteMeal(int Id)
    {
      await _meal.DeleteMeal(Id);

      return NoContent();
    }
  }
}
