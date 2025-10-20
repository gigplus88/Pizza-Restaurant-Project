using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Pizza_Project
{
    public partial class FrmPizzaProject : Form
    {
        public FrmPizzaProject()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }
        void UpdateSize()
        {
            UpdatePrice();

            if (rbLarge.Checked)
            {
                labelSizeValue.Text = "Large";
                return;
            }
            if (rbSmall.Checked)
            {
                labelSizeValue.Text = "Small";
                return;
            }
            if (rbMedium.Checked)
            {
                labelSizeValue.Text = "Medium";
                return;
            }
        }
        void UpdateCrustType()
        {
            UpdatePrice();

            if (rbThinCrust.Checked)
            {
                labelCrustTypeValue.Text = "Thin Crust";
                return;
            }

            if (rbThinkCrust.Checked)
            {
                labelCrustTypeValue.Text = "Think Crust";
                return;
            }

        }
        void UpdateToppings()
        {
            UpdatePrice();

            string Toppings = "";

           
            if (chkExtraChees.Checked)
            {
                Toppings += " Extra Chees ";
                
            }

            if (chkOnion.Checked)
            {
                Toppings += ", Onion ";
                
            }

            if (chkMushrooms.Checked)
            {
                Toppings += ", Mushrooms";
                
            }

            if (chkOlives.Checked)
            {
                Toppings += ", Olives";
                
            }

            if (chkTomatoes.Checked)
            {
                Toppings += ", Tomatoes";
                
            }

            if (chkGreenPeppers.Checked)
            {
                Toppings += ", GreenPeppers";
                
            }


            if (Toppings.StartsWith(","))
            {
                labelToppingValue.Text = Toppings.Substring(1, Toppings.Length-1);
            }

            

            if (Toppings == "")
                Toppings = "No Toppings";

            labelToppingValue.Text = Toppings;

        }
        void UpdateWhereToEat()
        {
          
            if (rbEatIn.Checked)
            {
                labelWhereToEatValue.Text = "Eat In";
                return;
            }

            if (rbTakeOut.Checked)
            {
                labelWhereToEatValue.Text = "Take Out";
                return;
            }
        }



        float GetTotalleSizeprice()
        {
            if (rbSmall.Checked)

                return Convert.ToSingle(rbSmall.Tag);

            else if (rbMedium.Checked)

                return Convert.ToSingle(rbMedium.Tag);

            else
                return Convert.ToSingle(rbLarge.Tag);

        }

        float GetTotalleCrustTypeprice()
        {
            if (rbThinCrust.Checked)

                return Convert.ToSingle(rbThinCrust.Tag);

            else 

                return Convert.ToSingle(rbThinkCrust.Tag);

        }

        float GenerateToppingsTotalleprice()
        {
            float ToppingsTotallePrice = 0f;

            if (chkExtraChees.Checked)

                ToppingsTotallePrice +=  Convert.ToSingle(chkExtraChees.Tag);

             if(chkOnion.Checked)

                ToppingsTotallePrice += Convert.ToSingle(chkOnion.Tag);

             if (chkOlives.Checked)

                ToppingsTotallePrice += Convert.ToSingle(chkOlives.Tag);

             if (chkMushrooms.Checked)

                ToppingsTotallePrice += Convert.ToSingle(chkMushrooms.Tag);

             if (chkTomatoes.Checked)

                ToppingsTotallePrice += Convert.ToSingle(chkTomatoes.Tag);

            if (chkGreenPeppers.Checked)

                ToppingsTotallePrice += Convert.ToSingle(chkGreenPeppers.Tag);

            return ToppingsTotallePrice;

        }

        float TotallePrices()
        {
            float Totale = GenerateToppingsTotalleprice() + GetTotalleCrustTypeprice() +  GetTotalleSizeprice();
            return Totale;
        }

        void UpdatePrice()
        {
            labelPriceValue.Text = TotallePrices().ToString();
        }
        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();

        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();

        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        
        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }


        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }



        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {

            UpdateToppings();

        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

       

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

     

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information )== DialogResult.OK)
                {
                    gpSize.Enabled = false;
                    gpCrustType.Enabled = false;
                    gpToppings.Enabled = false;
                    gpWhereToEat.Enabled = false;
                }


            }

            else

                MessageBox.Show("Update your order", "Update",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



        }

        void UpdateOrderSummary() // (group boxes)لكي يحسب البرنامج القيم المبدئية التي على 
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrustType();
            UpdateWhereToEat();
            UpdatePrice();

        }
        void ResetForm()
        {
            // For Groups
            gpSize.Enabled = true;
            gpCrustType.Enabled = true;
            gpToppings.Enabled = true;
            gpWhereToEat.Enabled = true;

            // Able to Medium
            rbMedium.Checked = true;

            // Able to Thin Crust
            rbThinCrust.Checked = true;

            // Able to Eat In
            rbEatIn.Checked = true;

            // Disable for toppings
            chkExtraChees.Checked = false;
            chkGreenPeppers.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;  
            chkTomatoes.Checked = false;
            chkOnion.Checked = false;            

        }
        private void btnResertForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

      
    }
}
