namespace Pizza_Project
{
    partial class FrmOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpOrderSummary = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelWhereToEatValue = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelWhereToEat = new System.Windows.Forms.Label();
            this.labelSizeValue = new System.Windows.Forms.Label();
            this.labelCrustTypeValue = new System.Windows.Forms.Label();
            this.labelToppingValue = new System.Windows.Forms.Label();
            this.labelCrustType = new System.Windows.Forms.Label();
            this.labelToppings = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPriceValue = new System.Windows.Forms.Label();
            this.gpOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpOrderSummary
            // 
            this.gpOrderSummary.BackColor = System.Drawing.Color.Transparent;
            this.gpOrderSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gpOrderSummary.Controls.Add(this.label3);
            this.gpOrderSummary.Controls.Add(this.labelPriceValue);
            this.gpOrderSummary.Controls.Add(this.label2);
            this.gpOrderSummary.Controls.Add(this.labelWhereToEatValue);
            this.gpOrderSummary.Controls.Add(this.labelSize);
            this.gpOrderSummary.Controls.Add(this.labelWhereToEat);
            this.gpOrderSummary.Controls.Add(this.labelSizeValue);
            this.gpOrderSummary.Controls.Add(this.labelCrustTypeValue);
            this.gpOrderSummary.Controls.Add(this.labelToppingValue);
            this.gpOrderSummary.Controls.Add(this.labelCrustType);
            this.gpOrderSummary.Controls.Add(this.labelToppings);
            this.gpOrderSummary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpOrderSummary.Location = new System.Drawing.Point(138, 71);
            this.gpOrderSummary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpOrderSummary.Name = "gpOrderSummary";
            this.gpOrderSummary.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpOrderSummary.Size = new System.Drawing.Size(332, 340);
            this.gpOrderSummary.TabIndex = 18;
            this.gpOrderSummary.TabStop = false;
            this.gpOrderSummary.Text = "Order Summary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Order Summary";
            // 
            // labelWhereToEatValue
            // 
            this.labelWhereToEatValue.AutoSize = true;
            this.labelWhereToEatValue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWhereToEatValue.Location = new System.Drawing.Point(136, 225);
            this.labelWhereToEatValue.Name = "labelWhereToEatValue";
            this.labelWhereToEatValue.Size = new System.Drawing.Size(40, 14);
            this.labelWhereToEatValue.TabIndex = 16;
            this.labelWhereToEatValue.Text = "Eat In";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.Location = new System.Drawing.Point(22, 77);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(39, 14);
            this.labelSize.TabIndex = 9;
            this.labelSize.Text = "Size: ";
            // 
            // labelWhereToEat
            // 
            this.labelWhereToEat.AutoSize = true;
            this.labelWhereToEat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWhereToEat.Location = new System.Drawing.Point(22, 227);
            this.labelWhereToEat.Name = "labelWhereToEat";
            this.labelWhereToEat.Size = new System.Drawing.Size(93, 14);
            this.labelWhereToEat.TabIndex = 15;
            this.labelWhereToEat.Text = "Where To Eat:";
            // 
            // labelSizeValue
            // 
            this.labelSizeValue.AutoSize = true;
            this.labelSizeValue.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelSizeValue.Location = new System.Drawing.Point(136, 76);
            this.labelSizeValue.Name = "labelSizeValue";
            this.labelSizeValue.Size = new System.Drawing.Size(28, 14);
            this.labelSizeValue.TabIndex = 10;
            this.labelSizeValue.Text = "Size";
            // 
            // labelCrustTypeValue
            // 
            this.labelCrustTypeValue.AutoSize = true;
            this.labelCrustTypeValue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrustTypeValue.Location = new System.Drawing.Point(136, 174);
            this.labelCrustTypeValue.Name = "labelCrustTypeValue";
            this.labelCrustTypeValue.Size = new System.Drawing.Size(54, 14);
            this.labelCrustTypeValue.TabIndex = 14;
            this.labelCrustTypeValue.Text = "No Type";
            // 
            // labelToppingValue
            // 
            this.labelToppingValue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToppingValue.Location = new System.Drawing.Point(136, 120);
            this.labelToppingValue.Name = "labelToppingValue";
            this.labelToppingValue.Size = new System.Drawing.Size(157, 54);
            this.labelToppingValue.TabIndex = 11;
            this.labelToppingValue.Text = "No Topping";
            this.labelToppingValue.UseCompatibleTextRendering = true;
            // 
            // labelCrustType
            // 
            this.labelCrustType.AutoSize = true;
            this.labelCrustType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrustType.Location = new System.Drawing.Point(22, 174);
            this.labelCrustType.Name = "labelCrustType";
            this.labelCrustType.Size = new System.Drawing.Size(77, 14);
            this.labelCrustType.TabIndex = 13;
            this.labelCrustType.Text = "Crust Type:";
            // 
            // labelToppings
            // 
            this.labelToppings.AutoSize = true;
            this.labelToppings.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToppings.Location = new System.Drawing.Point(22, 120);
            this.labelToppings.Name = "labelToppings";
            this.labelToppings.Size = new System.Drawing.Size(67, 14);
            this.labelToppings.TabIndex = 12;
            this.labelToppings.Text = "Toppings:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(4, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Total Price: ";
            // 
            // labelPriceValue
            // 
            this.labelPriceValue.AutoSize = true;
            this.labelPriceValue.BackColor = System.Drawing.Color.Transparent;
            this.labelPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceValue.ForeColor = System.Drawing.Color.Navy;
            this.labelPriceValue.Location = new System.Drawing.Point(152, 276);
            this.labelPriceValue.Name = "labelPriceValue";
            this.labelPriceValue.Size = new System.Drawing.Size(30, 25);
            this.labelPriceValue.TabIndex = 23;
            this.labelPriceValue.Text = "0 ";
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 545);
            this.Controls.Add(this.gpOrderSummary);
            this.Name = "FrmOrder";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            this.gpOrderSummary.ResumeLayout(false);
            this.gpOrderSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpOrderSummary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelWhereToEatValue;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelWhereToEat;
        private System.Windows.Forms.Label labelSizeValue;
        private System.Windows.Forms.Label labelCrustTypeValue;
        private System.Windows.Forms.Label labelToppingValue;
        private System.Windows.Forms.Label labelCrustType;
        private System.Windows.Forms.Label labelToppings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPriceValue;
    }
}