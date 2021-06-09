using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms.VisualStyles;
using Metro.Models;
using Metro.Models.DB;
using Metro.ViewModels;
using System.Data.Entity;

namespace Metro.Controllers
{
    public class HomeController : Controller
    {
        private readonly MetroContext _context;

        public HomeController()
        {
            _context = new MetroContext();
        }
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Government()
        {
            var humans = _context.Human.Include(c => c.Position).ToList();
            return View(humans);
        }

        public ActionResult Geography()
        {
            return View();
        }

        public ActionResult Economics()
        {
            return View();
        }

        public ActionResult Army()
        {
            return View();
        }

        public ActionResult CreateHuman()
        {

            var weapons = _context.Weapon.ToList();
            var stations = _context.Station.ToList();
            var positions = _context.Position.ToList();
            var viewModel = new HumanViewModel
            {
                Human = new Human(),
                Weapons = weapons,
                Stations = stations,
                Positions = positions
            };
            return View("CreateHuman", viewModel);
        }

        public ActionResult CreatePosition()
        {
            var position = new Position();
            return View("CreatePosition", position);
        }
        public ActionResult CreateWeapon()
        {
            var weapon = new Weapon();
            return View("CreateWeapon", weapon);
        }
        public ActionResult CreateStation()
        {
            var station = new Station();
            return View("CreateStation", station);
        }

        public ActionResult Admin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddHuman(Human human)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new HumanViewModel()
                {
                    Human = human,
                    Positions = _context.Position.ToList(),
                    Stations = _context.Station.ToList(),
                    Weapons = _context.Weapon.ToList()
                };
                return View("CreateHuman", viewModel);
            }
            if (human.Id == 0)
                _context.Human.Add(human);
            else
            {
                var humanInDb = _context.Human.Single(c => c.Id == human.Id);
                humanInDb.FirstName = human.FirstName;
                humanInDb.LastName = human.LastName;
                humanInDb.WeaponId = human.WeaponId;
                humanInDb.StationId = human.StationId;
                humanInDb.PositionId = human.PositionId;
            }
            _context.SaveChanges();
            return RedirectToAction("Admin", "Home");
        }
        [HttpPost]
        public ActionResult AddPosition(Position position)
        {
            if (!ModelState.IsValid)
            {

                return View("CreatePosition", position);
            }
            if (position.Id == 0)
                _context.Position.Add(position);
            else
            {
                var positionInDb = _context.Position.Single(c => c.Id == position.Id);
                positionInDb.Name = position.Name;
            }
            _context.SaveChanges();
            return RedirectToAction("Admin", "Home");
        }
        [HttpPost]
        public ActionResult AddWeapon(Weapon weapon)
        {
            if (!ModelState.IsValid)
            {

                return View("CreateWeapon", weapon);
            }
            if (weapon.Id == 0)
                _context.Weapon.Add(weapon);
            else
            {
                var weaponInDb = _context.Weapon.Single(c => c.Id == weapon.Id);
                weaponInDb.Name = weapon.Name;
                weaponInDb.Caliber = weapon.Caliber;
            }
            _context.SaveChanges();
            return RedirectToAction("Admin", "Home");
        }
        [HttpPost]
        public ActionResult AddStation(Station station)
        {
            if (!ModelState.IsValid)
            {
                
                return View("CreateStation", station);
            }
            if (station.Id == 0)
                _context.Station.Add(station);
            else
            {
                var stationInDb = _context.Station.Single(c => c.Id == station.Id);
                stationInDb.Name = station.Name;
                stationInDb.Population = station.Population;
            }
            _context.SaveChanges();
            return RedirectToAction("Admin", "Home");
        }
    }
}