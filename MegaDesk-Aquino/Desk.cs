﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Aquino
{
    public enum DesktopMaterial
    {
        Laminate, 
        Oak, 
        Rosewood,
        Veneer,
        Pine
    }
    class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public DesktopMaterial SurfaceMaterial { get; set; }


    }
}
