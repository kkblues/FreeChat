﻿using System;

namespace FreeChat.Models.DTO
{
    public class TopicsDto
    {
        public TopicsDto()
        {

        }
        public string Name { get; set; }
        public string Genre { get; set; }
        public bool Active { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateExpired { get; set; }

    }
}