﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NIK.BoulderDash.Logic
{
    public class DynamicBlock: Block
    {
        private Point tilePosition;
        public ref Point TilePosition { get => ref tilePosition; }

        private Point tileOldPosition;
        public ref Point TileOldPosition { get => ref tileOldPosition; }

    }
}
