﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce_App.Auth.Models.DTO
{
  public class UserDTO
  {
    public string Id { get; set; }
    public string UserName { get; set; }
    public IList<string> Roles { get; set; }
  }
}
