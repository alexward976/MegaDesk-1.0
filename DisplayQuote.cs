using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class DisplayQuote : Form
    {
        
        public DisplayQuote(DeskQuote newDeskQuote)
        {
            InitializeComponent();

            QuoteDate.Text = newDeskQuote.quoteDate.ToString("MMMM dd, yyyy");

            QuoteTotal.Text = $"${Convert.ToString(newDeskQuote.calcTotal())}.00";

            CustName.Text = newDeskQuote.custName;
            Width.Text = $"{Convert.ToString(newDeskQuote.desk.width)} inches";
            Depth.Text = $"{Convert.ToString(newDeskQuote.desk.depth)} inches";
            Drawers.Text = $"{Convert.ToString(newDeskQuote.desk.drawers)} drawers";
            SurfaceMaterial.Text = Convert.ToString(newDeskQuote.desk.deskMaterial);
            RushOrder.Text = $"{Convert.ToString(newDeskQuote.rushDays)} days";

        }
    }
}
