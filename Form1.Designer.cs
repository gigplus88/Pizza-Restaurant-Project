namespace Pizza_Project
{
    partial class FrmPizzaProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.gpSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gpCrustType = new System.Windows.Forms.GroupBox();
            this.rbThinkCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gpWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.gpToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelSizeValue = new System.Windows.Forms.Label();
            this.labelToppingValue = new System.Windows.Forms.Label();
            this.labelToppings = new System.Windows.Forms.Label();
            this.labelCrustType = new System.Windows.Forms.Label();
            this.labelCrustTypeValue = new System.Windows.Forms.Label();
            this.labelWhereToEat = new System.Windows.Forms.Label();
            this.labelWhereToEatValue = new System.Windows.Forms.Label();
            this.gpOrderSummary = new System.Windows.Forms.GroupBox();
            this.labelPriceValue = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResertForm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gpSize.SuspendLayout();
            this.gpCrustType.SuspendLayout();
            this.gpWhereToEat.SuspendLayout();
            this.gpToppings.SuspendLayout();
            this.gpOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(211, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAKE YOUR PIZZA";
            // 
            // gpSize
            // 
            this.gpSize.BackColor = System.Drawing.Color.Transparent;
            this.gpSize.Controls.Add(this.rbLarge);
            this.gpSize.Controls.Add(this.rbMedium);
            this.gpSize.Controls.Add(this.rbSmall);
            this.gpSize.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSize.Location = new System.Drawing.Point(19, 119);
            this.gpSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpSize.Name = "gpSize";
            this.gpSize.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpSize.Size = new System.Drawing.Size(202, 162);
            this.gpSize.TabIndex = 2;
            this.gpSize.TabStop = false;
            this.gpSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(19, 116);
            this.rbLarge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(55, 18);
            this.rbLarge.TabIndex = 6;
            this.rbLarge.Tag = "30";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Checked = true;
            this.rbMedium.Location = new System.Drawing.Point(19, 76);
            this.rbMedium.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(67, 18);
            this.rbMedium.TabIndex = 5;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "20";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(19, 32);
            this.rbSmall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(52, 18);
            this.rbSmall.TabIndex = 3;
            this.rbSmall.Tag = "10";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gpCrustType
            // 
            this.gpCrustType.BackColor = System.Drawing.Color.Transparent;
            this.gpCrustType.Controls.Add(this.rbThinkCrust);
            this.gpCrustType.Controls.Add(this.rbThinCrust);
            this.gpCrustType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpCrustType.Location = new System.Drawing.Point(19, 292);
            this.gpCrustType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpCrustType.Name = "gpCrustType";
            this.gpCrustType.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpCrustType.Size = new System.Drawing.Size(202, 113);
            this.gpCrustType.TabIndex = 3;
            this.gpCrustType.TabStop = false;
            this.gpCrustType.Text = "Crust Type";
            // 
            // rbThinkCrust
            // 
            this.rbThinkCrust.AutoSize = true;
            this.rbThinkCrust.Location = new System.Drawing.Point(19, 76);
            this.rbThinkCrust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbThinkCrust.Name = "rbThinkCrust";
            this.rbThinkCrust.Size = new System.Drawing.Size(87, 18);
            this.rbThinkCrust.TabIndex = 5;
            this.rbThinkCrust.Tag = "20";
            this.rbThinkCrust.Text = "Think Crust";
            this.rbThinkCrust.UseVisualStyleBackColor = true;
            this.rbThinkCrust.CheckedChanged += new System.EventHandler(this.rbThinkCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Checked = true;
            this.rbThinCrust.Location = new System.Drawing.Point(19, 32);
            this.rbThinCrust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(81, 18);
            this.rbThinCrust.TabIndex = 3;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "15";
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // gpWhereToEat
            // 
            this.gpWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.gpWhereToEat.Controls.Add(this.rbTakeOut);
            this.gpWhereToEat.Controls.Add(this.rbEatIn);
            this.gpWhereToEat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpWhereToEat.Location = new System.Drawing.Point(282, 292);
            this.gpWhereToEat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpWhereToEat.Name = "gpWhereToEat";
            this.gpWhereToEat.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpWhereToEat.Size = new System.Drawing.Size(219, 113);
            this.gpWhereToEat.TabIndex = 6;
            this.gpWhereToEat.TabStop = false;
            this.gpWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(111, 50);
            this.rbTakeOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(77, 18);
            this.rbTakeOut.TabIndex = 5;
            this.rbTakeOut.Tag = "5";
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Checked = true;
            this.rbEatIn.Location = new System.Drawing.Point(5, 50);
            this.rbEatIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(58, 18);
            this.rbEatIn.TabIndex = 3;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Tag = "5";
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // gpToppings
            // 
            this.gpToppings.BackColor = System.Drawing.Color.Transparent;
            this.gpToppings.Controls.Add(this.chkGreenPeppers);
            this.gpToppings.Controls.Add(this.chkTomatoes);
            this.gpToppings.Controls.Add(this.chkOlives);
            this.gpToppings.Controls.Add(this.chkMushrooms);
            this.gpToppings.Controls.Add(this.chkOnion);
            this.gpToppings.Controls.Add(this.chkExtraChees);
            this.gpToppings.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpToppings.Location = new System.Drawing.Point(282, 119);
            this.gpToppings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpToppings.Name = "gpToppings";
            this.gpToppings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpToppings.Size = new System.Drawing.Size(220, 162);
            this.gpToppings.TabIndex = 7;
            this.gpToppings.TabStop = false;
            this.gpToppings.Text = "Toppings";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(111, 117);
            this.chkGreenPeppers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(107, 18);
            this.chkGreenPeppers.TabIndex = 13;
            this.chkGreenPeppers.Tag = "5";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(5, 116);
            this.chkTomatoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(81, 18);
            this.chkTomatoes.TabIndex = 12;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(111, 76);
            this.chkOlives.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(57, 18);
            this.chkOlives.TabIndex = 11;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(5, 76);
            this.chkMushrooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(87, 18);
            this.chkMushrooms.TabIndex = 10;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(111, 32);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(58, 18);
            this.chkOnion.TabIndex = 9;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Location = new System.Drawing.Point(5, 32);
            this.chkExtraChees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(91, 18);
            this.chkExtraChees.TabIndex = 8;
            this.chkExtraChees.Tag = "5";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkExtraChees_CheckedChanged);
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
            // gpOrderSummary
            // 
            this.gpOrderSummary.BackColor = System.Drawing.Color.Transparent;
            this.gpOrderSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
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
            this.gpOrderSummary.Location = new System.Drawing.Point(615, 119);
            this.gpOrderSummary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpOrderSummary.Name = "gpOrderSummary";
            this.gpOrderSummary.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpOrderSummary.Size = new System.Drawing.Size(302, 287);
            this.gpOrderSummary.TabIndex = 17;
            this.gpOrderSummary.TabStop = false;
            this.gpOrderSummary.Text = "Order Summary";
            // 
            // labelPriceValue
            // 
            this.labelPriceValue.AutoSize = true;
            this.labelPriceValue.BackColor = System.Drawing.Color.Transparent;
            this.labelPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.labelPriceValue.ForeColor = System.Drawing.Color.Navy;
            this.labelPriceValue.Location = new System.Drawing.Point(872, 444);
            this.labelPriceValue.Name = "labelPriceValue";
            this.labelPriceValue.Size = new System.Drawing.Size(57, 51);
            this.labelPriceValue.TabIndex = 18;
            this.labelPriceValue.Text = "0 ";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderPizza.Location = new System.Drawing.Point(302, 431);
            this.btnOrderPizza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(99, 41);
            this.btnOrderPizza.TabIndex = 17;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResertForm
            // 
            this.btnResertForm.BackColor = System.Drawing.Color.Transparent;
            this.btnResertForm.Location = new System.Drawing.Point(470, 431);
            this.btnResertForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResertForm.Name = "btnResertForm";
            this.btnResertForm.Size = new System.Drawing.Size(99, 41);
            this.btnResertForm.TabIndex = 20;
            this.btnResertForm.Text = "Reset Form";
            this.btnResertForm.UseVisualStyleBackColor = false;
            this.btnResertForm.Click += new System.EventHandler(this.btnResertForm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(649, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Total Price: ";
            // 
            // FrmPizzaProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 504);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnResertForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gpOrderSummary);
            this.Controls.Add(this.labelPriceValue);
            this.Controls.Add(this.gpToppings);
            this.Controls.Add(this.gpWhereToEat);
            this.Controls.Add(this.gpCrustType);
            this.Controls.Add(this.gpSize);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPizzaProject";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpSize.ResumeLayout(false);
            this.gpSize.PerformLayout();
            this.gpCrustType.ResumeLayout(false);
            this.gpCrustType.PerformLayout();
            this.gpWhereToEat.ResumeLayout(false);
            this.gpWhereToEat.PerformLayout();
            this.gpToppings.ResumeLayout(false);
            this.gpToppings.PerformLayout();
            this.gpOrderSummary.ResumeLayout(false);
            this.gpOrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gpCrustType;
        private System.Windows.Forms.RadioButton rbThinkCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.GroupBox gpWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.GroupBox gpToppings;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelSizeValue;
        private System.Windows.Forms.Label labelToppingValue;
        private System.Windows.Forms.Label labelToppings;
        private System.Windows.Forms.Label labelCrustType;
        private System.Windows.Forms.Label labelCrustTypeValue;
        private System.Windows.Forms.Label labelWhereToEat;
        private System.Windows.Forms.Label labelWhereToEatValue;
        private System.Windows.Forms.GroupBox gpOrderSummary;
        private System.Windows.Forms.Label labelPriceValue;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResertForm;
        private System.Windows.Forms.Label label3;
    }
}

