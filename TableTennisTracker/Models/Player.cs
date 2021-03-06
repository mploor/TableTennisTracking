﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTennisTracker.Services;

namespace TableTennisTracker.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PlayerName { get; set; }
        public int Age { get; set; }
        public int HeightFt { get; set; }
        public int HeightInch { get; set; }
        public string Nationality { get; set; }
        public string HandPreference { get; set; }
        public bool IsSelected { get; set; } = false;
        public int Wins { get; set; }
        public int Losses { get; set; }

        public ICollection<GamePlayer> GamePlayer { get; set; }

    }
}
