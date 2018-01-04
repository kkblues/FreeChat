﻿using FreeChat.Models.ViewModels;
using FreeChat.Services.ServicesInterfaces;
using System.Web.Mvc;

namespace FreeChat.Controllers
{
    public class ChatRoomController : Controller
    {
        private readonly ITopicsService _service;

        public ChatRoomController(ITopicsService service)
        {
            _service = service;
        }


        public ActionResult Create()
        {
            var mainCategories = _service.GetMainCategories();

            return View("Create", new CreateRoomViewModel { MainCategories = mainCategories });
        }
    }
}