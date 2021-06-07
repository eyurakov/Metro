using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Metro.Models
{
    public class Station
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Population { get; set; }
        

    }
}