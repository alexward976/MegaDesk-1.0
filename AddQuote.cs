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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuoteCloseButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void WidthInput_Validating(object sender, CancelEventArgs e)
        {
            string typeErrorMessage = "Width needs to be an integer (no decimal)";
            string valueErrorMessage = "Width needs to be between 24 and 96";


            try
            {
                int widthInputValue = Convert.ToInt32(WidthInput.Text);

                Type widthInputType = widthInputValue.GetType();

                if (widthInputValue < 24 || widthInputValue > 96)
                {
                    e.Cancel = true;
                    WidthInput.Select(0, WidthInput.Text.Length);

                    this.errorProvider1.SetError(WidthInput, valueErrorMessage);
                }
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                WidthInput.Select(0, WidthInput.Text.Length);

                this.errorProvider1.SetError(WidthInput, typeErrorMessage);
            }
            
        }

        private void WidthInput_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(WidthInput, "");
        }

        private bool nonNumberEntered = false;

        private void DepthInput_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }

            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void DepthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(nonNumberEntered)
            {
                e.Handled = true;
            }
        }

        private void ViewTotalButton_Click(object sender, EventArgs e)
        {   
            int widthInputValue = Convert.ToInt32(WidthInput.Text);
            int depthInputValue = Convert.ToInt32(DepthInput.Text);
            int drawersInputValue = Convert.ToInt32(DrawersInput.Text);
            int rushInputValue = Convert.ToInt32(RushOrderInput.Text);

            DesktopMaterial surfaceMaterial;

            switch(SurfaceMaterialInput.Text)
            {
                case "laminate":
                    surfaceMaterial = DesktopMaterial.Laminate;
                    break;

                case "oak":
                    surfaceMaterial = DesktopMaterial.Oak;
                    break;

                case "pine":
                    surfaceMaterial = DesktopMaterial.Pine;
                    break;

                case "rosewood":
                    surfaceMaterial = DesktopMaterial.Rosewood;
                    break;

                case "veneer":
                    surfaceMaterial = DesktopMaterial.Veneer;
                    break;

                default:
                    surfaceMaterial = DesktopMaterial.Pine;
                    break;
            }

            Desk newDesk = new Desk(widthInputValue, depthInputValue, drawersInputValue, surfaceMaterial);
            DeskQuote newDeskQuote = new DeskQuote(newDesk, rushInputValue, CustNameInput.Text, DateTime.Now);


            DisplayQuote viewDisplayQuote = new DisplayQuote(newDeskQuote);
            viewDisplayQuote.Tag = this;
            viewDisplayQuote.Show(this);
            Hide();
        }

    }
}
