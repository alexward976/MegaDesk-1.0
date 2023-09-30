using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{ 

    public enum DesktopMaterial {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    };

    public class Desk
    {
        private int WIDTH_MIN = 24;
        private int WIDTH_MAX = 96;
        private int DEPTH_MIN = 12;
        private int DEPTH_MAX = 48;

        public int width;
        public int depth;
        public int drawers;
        public DesktopMaterial deskMaterial;
        public Desk(int width, int depth, int drawers, DesktopMaterial deskMaterial)
        {
            this.width = width;
            this.depth = depth;
            this.drawers = drawers;
            this.deskMaterial = deskMaterial;
        }
    }
}
