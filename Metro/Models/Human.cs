using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Metro.Models
{
    public class Human
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Position Position { get; set; }

        [Display(Name = "Position")]
        public int PositionId { get; set; }

        public Station Station { get; set; }

        [Display(Name = "Station")]
        [ForeignKey("StationId")]

        public int StationId { get; set; }
        public Weapon Weapon { get; set; }
        [Display(Name = "Weapon")]
        public int WeaponId { get; set; }
    }
}