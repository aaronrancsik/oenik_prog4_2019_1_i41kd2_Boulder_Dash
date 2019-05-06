﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using NIK.BoulderDash.Logic.Blocks;
namespace NIK.BoulderDash.Logic
{
    public class GameModel 
    {
        public GameModel()
        {
           
        }
        public int CollectedDiamonds { get; set; };
        public int RequireDiamonds { get; set; }
        public Point ExitPistition { get; set; }
        
        public List<Diamond> Diamonds { get; private set; }
        public List<Boulder> Boulders { get; private set; }
        public Dirt[,] DirtMatrix { get; set; }
        public bool[,] TitaniumMatrix { get; set; }
        public bool[,] WallMatrix { get; set; }
        public Player Player { get; private set; }
    }
}
