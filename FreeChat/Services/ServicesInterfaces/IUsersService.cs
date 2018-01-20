﻿using FreeChat.Models;
using System.Collections.Generic;

namespace FreeChat.Services.ServicesInterfaces
{
    public interface IUsersService
    {
        long CountRegisteredUsers();
        IEnumerable<ApplicationUser> GetRegisteredUsers();

    }
}