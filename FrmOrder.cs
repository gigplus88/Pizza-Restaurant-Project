using Pizz_aBusiness_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class FrmOrder : Form
    {
        clsPizzaClient _pizzaClient ;
        public FrmOrder()
        {
            InitializeComponent();
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            ReceiveOrder();
        }

        private void ReceiveOrder()
        {
            var OrderResult = clsPizzaClient.ReceiveOrder();

            labelToppingValue.Text = OrderResult.Toppings;
            labelSizeValue.Text = OrderResult.Size;
            labelCrustTypeValue.Text = OrderResult.CrustType;
            labelWhereToEatValue.Text = OrderResult.WhereToEat;
            labelPriceValue.Text = OrderResult.TotalPrice;
        }

    }
}
