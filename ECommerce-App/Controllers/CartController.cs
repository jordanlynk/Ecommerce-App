﻿using ECommerce_App.Auth.Services.Interfaces;
using ECommerce_App.Data;
using ECommerce_App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce_App.Controllers
{
  public class CartController : Controller
  {
    private readonly ICart _cart;


    public CartController(ICart cart)
    {
      _cart = cart;
    }
    public IActionResult Index()
    {
      return View();
    }
    [HttpPost]
    public async Task<ActionResult<CreateCart>> Create(CreateCart cart) 
      {
           await _cart.Create(cart);
           return CreatedAtAction("GetCartItems", new { id = cart.Id}, cart);
      }

    [HttpGet]
    public async Task<ActionResult<CreateCart>> GetCartItems(int id)
    {
      CreateCart cart = await _cart.GetCartItems(id);
      return cart;
    }

    [HttpPost]
    public async Task<ActionResult> AddItemToCart(int cartId, int productId, int price)
    {
      await _cart.AddItemToCart(cartId, productId, price);
      return RedirectToPage("/cart");
    }

  }
}