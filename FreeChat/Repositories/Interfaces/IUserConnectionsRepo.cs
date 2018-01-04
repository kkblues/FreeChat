﻿using System.Collections.Generic;
using FreeChat.Models.Domain;

namespace FreeChat.Repositories.Interfaces
{
    public interface IUserConnectionsRepo
    {
        bool AddUserConnection(long connectionId, int userId);
        bool RemoveUserConnection(long connectionId);
        IEnumerable<UserConnections> GetUserConnectionsIdsByUserId(long id);
        bool RemoveUserConnections(long id);
    }
}