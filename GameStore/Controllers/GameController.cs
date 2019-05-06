using System;
using System.Collections.Generic;
using System.Linq;
using GameStore.Data;
using GameStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new GameStoreDb())
            {
                List<Game> games = db.Games.ToList();
                return View(games);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Game game)
        {
            using (var db = new GameStoreDb())
            {
                db.Games.Add(game);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new GameStoreDb())
            {
                Game game = db.Games.Find(id);
                return View(game);
            }
        }

        [HttpPost]
        public IActionResult Edit(Game game)
        {
            using (var db = new GameStoreDb())
            {
                db.Games.Update(game);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new GameStoreDb())
            {
                Game game = db.Games.Find(id);
                return View(game);
            }
        }

        [HttpPost]
        public IActionResult Delete(Game game)
        {
            using (var db = new GameStoreDb())
            {
                db.Games.Remove(game);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}