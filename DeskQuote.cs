using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public class DeskQuote
    {
        public Desk desk;
        public int rushDays;
        public string custName;
        public DateTime quoteDate;

        private int BASE_DESK_PRICE = 200;

        public DeskQuote(Desk desk, int rushDays, string custName, DateTime quoteDate)
        {
            this.desk = desk;
            this.rushDays = rushDays;
            this.custName = custName;
            this.quoteDate = quoteDate;
        }

        private int calcSurfaceArea()
        {
            return this.desk.width * this.desk.depth;
        }

        private int calcDrawerPrice()
        {
            return this.desk.drawers * 50;
        }

        private int calcMaterialPrice()
        {
            switch (this.desk.deskMaterial)
            {
                case DesktopMaterial.Laminate:
                    return 100;

                case DesktopMaterial.Oak:
                    return 200;

                case DesktopMaterial.Pine:
                    return 50;

                case DesktopMaterial.Rosewood:
                    return 300;

                case DesktopMaterial.Veneer:
                    return 125;

                default:
                    return 0;                    
            }
        }

        private int calcRushPrice()
        {
            int surfaceArea = calcSurfaceArea();

            switch(this.rushDays)
            {
                case 3:
                    if(surfaceArea < 1000)
                    {
                        return 60;
                    } else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        return 70;
                    } else
                    {
                        return 80;
                    }

                case 5:
                    if (surfaceArea < 1000)
                    {
                        return 40;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        return 50;
                    }
                    else
                    {
                        return 60;
                    }

                case 7:
                    if (surfaceArea < 1000)
                    {
                        return 30;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        return 35;
                    }
                    else
                    {
                        return 40;
                    }

                default: return 0;
            }
        }

        public int calcTotal()
        {
            int total = this.BASE_DESK_PRICE;
            int surfaceArea = calcSurfaceArea();

            if (surfaceArea > 1000)
            {
                total += surfaceArea;
            }
            
            total += this.calcDrawerPrice();
            total += this.calcMaterialPrice();
            total += this.calcRushPrice();

            return total;
        }

    }
}
