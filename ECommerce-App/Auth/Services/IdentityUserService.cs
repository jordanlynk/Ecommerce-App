﻿
using ECommerce_App.Auth.Models;
using ECommerce_App.Auth.Models.DTO;
using ECommerce_App.Auth.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ECommerce_App.Auth.Services
{
  public class IdentityUserService : IUserService
  {
    private UserManager<AuthUser> userManager;
    private SignInManager<AuthUser> signInManager;
    public IdentityUserService(UserManager<AuthUser> manager, SignInManager<AuthUser> sim)
    {
      userManager = manager;
      signInManager = sim;
    } 

    public async Task<UserDTO> Register(RegisterDTO data, ModelStateDictionary modelState)
    {
      var user = new AuthUser
      {
        UserName = data.UserName,
        Email = data.Email,
        PhoneNumber = data.PhoneNumber
      };
      var result = await userManager.CreateAsync(user, data.Password);
      if (result.Succeeded)
      {
        await userManager.AddToRolesAsync(user, data.Roles);

        return new UserDTO
        {
          Id = user.Id,
          UserName = user.UserName,
          Roles = await userManager.GetRolesAsync(user)
        };
      }
      foreach(var error in result.Errors)
      {
        var errorKey =
          error.Code.Contains("Password") ? nameof(data.Password) :
          error.Code.Contains("Email") ? nameof(data.Email) :
          error.Code.Contains("UserName") ? nameof(data.UserName) :
          "";
        modelState.AddModelError(errorKey, error.Description);
      }
      return null;
    }
    private TimeSpan TimeSpan(object P)
    {
      throw new NotImplementedException();
    }

    public async Task<UserDTO> Authenticate(string userName, string password)
    {
      var result = await signInManager.PasswordSignInAsync(userName, password, true, false);
      if (result.Succeeded)
      {
        var user = await userManager.FindByNameAsync(userName);
        return new UserDTO
        {
          Id = user.Id,
          UserName = user.UserName,
          Roles = await userManager.GetRolesAsync(user)
        };
      }
      return null;
    }

    public async Task<UserDTO> GetUser(ClaimsPrincipal principal)
    {
      var user = await userManager.GetUserAsync(principal);
      return new UserDTO
      {
        Id = user.Id,
        UserName = user.UserName,
        Roles = await userManager.GetRolesAsync(user)
      };
    }
  }
}
