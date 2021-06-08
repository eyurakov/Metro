using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Metro.Models;

namespace Metro.ViewModels
{
    public class HumanViewModel
    {
        public IEnumerable<Position> Positions { get; set; }
        public IEnumerable<Weapon> Weapons { get; set; }
        public IEnumerable<Station> Stations { get; set; }
        public Human Human { get; set; }
    }
}