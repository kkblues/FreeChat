﻿using System;
using System.Collections.Generic;

namespace FreeChat.Core.Models.Domain
{
    public class Topic
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Genre { get; set; }

        public string Description { get; set; }

        public bool Active { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateExpired { get; set; }

        public long MaxClientsOnline { get; set; }

        public User UserCreator { get; set; }

        public string UserCreatorId { get; set; }

        public byte MainCategoryId { get; set; }

        public virtual MainCategory MainCategory { get; set; }

        public IList<User> UsersOnline { get; set; }


        public Topic()
        {
            UsersOnline = new List<User>();
        }
    }
}