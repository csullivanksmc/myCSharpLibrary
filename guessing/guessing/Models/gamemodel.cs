using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace guessing.Models
{
    public class gamemodel
    {
        [Display(Name = "player name")]
        public string PlayerName { get; set; }

        [Display(Name = "your guess")]
        public int Guess { get; set; }
    }
}
