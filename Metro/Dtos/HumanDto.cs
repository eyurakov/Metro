using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Metro.Models;

namespace Metro.Dtos
{
    public class HumanDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Position Position { get; set; }

        [Display(Name = "Position")]
        public byte PositionId { get; set; }

        public Station Station { get; set; }

        [Display(Name = "Station")]
        [ForeignKey("StationId")]

        public int StationId { get; set; }
        public Weapon Weapon { get; set; }
        [Display(Name = "Weapon")]
        public byte WeaponId { get; set; }
    }
}