namespace HuyserCG1
{
    partial class TechMarketingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ExitButton = new Button();
            CustomerNameLabel = new Label();
            PhoneNumberLabel = new Label();
            CustomerNameTextBox = new TextBox();
            ConnectWithUsLabel = new Label();
            CustomerPhoneNumberMaskedTextBox = new MaskedTextBox();
            ProductSelectionGroupBox = new GroupBox();
            ProductSelectionRadioButton5 = new RadioButton();
            ProductSelectionRadioButton4 = new RadioButton();
            ProductSelectionRadioButton3 = new RadioButton();
            ProductSelectionRadioButton2 = new RadioButton();
            ProductSelectionRadioButton1 = new RadioButton();
            panel1 = new Panel();
            ColorBlueButton = new Button();
            ColorPurpleButton = new Button();
            ColorGreenButton = new Button();
            ColorRedButton = new Button();
            ProductPictureBox = new PictureBox();
            DescriptionLabel = new Label();
            PlugPictureBox = new PictureBox();
            SalesRepStatusStrip = new StatusStrip();
            SalesRepStatusStripLabel = new ToolStripStatusLabel();
            ResetButtonToolTip = new ToolTip(components);
            ExitButtonToolTip = new ToolTip(components);
            QuantityTextBox = new TextBox();
            AddToOrderButton = new Button();
            ManagementTotalsButton = new Button();
            NewCustomerButton = new Button();
            EndOrderButton = new Button();
            TestButton = new Button();
            TechMarketingToolTip = new ToolTip(components);
            CustomerAddressLabel = new Label();
            CustomerCityLabel = new Label();
            CustomerStateLabel = new Label();
            QuantityLabel = new Label();
            CustomerZipLabel = new Label();
            CustomerAddressTextBox = new TextBox();
            CustomerCityTextBox = new TextBox();
            CustomerStateTextBox = new TextBox();
            TaxRateGroupBox = new GroupBox();
            TaxRateRadioButton3 = new RadioButton();
            TaxRateRadioButton2 = new RadioButton();
            TaxRateRadioButton1 = new RadioButton();
            DiscountCheckBox = new CheckBox();
            AdministrativePanel = new Panel();
            PackagingOptionsGroupBox = new GroupBox();
            PackagingOptionsCheckBox4 = new CheckBox();
            PackagingOptionsCheckBox3 = new CheckBox();
            PackagingOptionsCheckBox2 = new CheckBox();
            PackagingOptionsCheckBox1 = new CheckBox();
            CustomerZipMaskedTextBox = new MaskedTextBox();
            ReceiptLabel = new Label();
            ProductSelectionGroupBox.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlugPictureBox).BeginInit();
            SalesRepStatusStrip.SuspendLayout();
            TaxRateGroupBox.SuspendLayout();
            AdministrativePanel.SuspendLayout();
            PackagingOptionsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(980, 1365);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(150, 46);
            ExitButton.TabIndex = 18;
            ExitButton.Text = "Exit";
            TechMarketingToolTip.SetToolTip(ExitButton, "Exit");
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.AutoSize = true;
            CustomerNameLabel.Location = new Point(244, 166);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(193, 32);
            CustomerNameLabel.TabIndex = 0;
            CustomerNameLabel.Text = "Customer &Name:";
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Location = new Point(288, 396);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(149, 32);
            PhoneNumberLabel.TabIndex = 10;
            PhoneNumberLabel.Text = "Enter &Phone:";
            // 
            // CustomerNameTextBox
            // 
            CustomerNameTextBox.Location = new Point(443, 159);
            CustomerNameTextBox.Name = "CustomerNameTextBox";
            CustomerNameTextBox.Size = new Size(200, 39);
            CustomerNameTextBox.TabIndex = 1;
            // 
            // ConnectWithUsLabel
            // 
            ConnectWithUsLabel.AutoSize = true;
            ConnectWithUsLabel.Font = new Font("Times New Roman", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            ConnectWithUsLabel.ForeColor = Color.Blue;
            ConnectWithUsLabel.Location = new Point(284, 31);
            ConnectWithUsLabel.Name = "ConnectWithUsLabel";
            ConnectWithUsLabel.Size = new Size(405, 61);
            ConnectWithUsLabel.TabIndex = 8;
            ConnectWithUsLabel.Text = "Apple Ordering!";
            // 
            // CustomerPhoneNumberMaskedTextBox
            // 
            CustomerPhoneNumberMaskedTextBox.Location = new Point(443, 393);
            CustomerPhoneNumberMaskedTextBox.Mask = "000-0000";
            CustomerPhoneNumberMaskedTextBox.Name = "CustomerPhoneNumberMaskedTextBox";
            CustomerPhoneNumberMaskedTextBox.Size = new Size(111, 39);
            CustomerPhoneNumberMaskedTextBox.TabIndex = 11;
            // 
            // ProductSelectionGroupBox
            // 
            ProductSelectionGroupBox.Controls.Add(ProductSelectionRadioButton5);
            ProductSelectionGroupBox.Controls.Add(ProductSelectionRadioButton4);
            ProductSelectionGroupBox.Controls.Add(ProductSelectionRadioButton3);
            ProductSelectionGroupBox.Controls.Add(ProductSelectionRadioButton2);
            ProductSelectionGroupBox.Controls.Add(ProductSelectionRadioButton1);
            ProductSelectionGroupBox.Location = new Point(12, 585);
            ProductSelectionGroupBox.Name = "ProductSelectionGroupBox";
            ProductSelectionGroupBox.Size = new Size(837, 336);
            ProductSelectionGroupBox.TabIndex = 14;
            ProductSelectionGroupBox.TabStop = false;
            ProductSelectionGroupBox.Text = "Select a connection to learn more about it:";
            // 
            // ProductSelectionRadioButton5
            // 
            ProductSelectionRadioButton5.AutoSize = true;
            ProductSelectionRadioButton5.Location = new Point(19, 253);
            ProductSelectionRadioButton5.Name = "ProductSelectionRadioButton5";
            ProductSelectionRadioButton5.Size = new Size(184, 36);
            ProductSelectionRadioButton5.TabIndex = 4;
            ProductSelectionRadioButton5.TabStop = true;
            ProductSelectionRadioButton5.Text = "radioButton5";
            ProductSelectionRadioButton5.UseVisualStyleBackColor = true;
            ProductSelectionRadioButton5.CheckedChanged += ProductSelectionRadioButton_CheckedChanged;
            // 
            // ProductSelectionRadioButton4
            // 
            ProductSelectionRadioButton4.AutoSize = true;
            ProductSelectionRadioButton4.Location = new Point(18, 203);
            ProductSelectionRadioButton4.Name = "ProductSelectionRadioButton4";
            ProductSelectionRadioButton4.Size = new Size(184, 36);
            ProductSelectionRadioButton4.TabIndex = 3;
            ProductSelectionRadioButton4.TabStop = true;
            ProductSelectionRadioButton4.Text = "radioButton4";
            ProductSelectionRadioButton4.UseVisualStyleBackColor = true;
            ProductSelectionRadioButton4.CheckedChanged += ProductSelectionRadioButton_CheckedChanged;
            // 
            // ProductSelectionRadioButton3
            // 
            ProductSelectionRadioButton3.AutoSize = true;
            ProductSelectionRadioButton3.Location = new Point(19, 152);
            ProductSelectionRadioButton3.Name = "ProductSelectionRadioButton3";
            ProductSelectionRadioButton3.Size = new Size(184, 36);
            ProductSelectionRadioButton3.TabIndex = 2;
            ProductSelectionRadioButton3.TabStop = true;
            ProductSelectionRadioButton3.Text = "radioButton3";
            ProductSelectionRadioButton3.UseVisualStyleBackColor = true;
            ProductSelectionRadioButton3.CheckedChanged += ProductSelectionRadioButton_CheckedChanged;
            // 
            // ProductSelectionRadioButton2
            // 
            ProductSelectionRadioButton2.AutoSize = true;
            ProductSelectionRadioButton2.Location = new Point(19, 100);
            ProductSelectionRadioButton2.Name = "ProductSelectionRadioButton2";
            ProductSelectionRadioButton2.Size = new Size(184, 36);
            ProductSelectionRadioButton2.TabIndex = 1;
            ProductSelectionRadioButton2.TabStop = true;
            ProductSelectionRadioButton2.Text = "radioButton2";
            ProductSelectionRadioButton2.UseVisualStyleBackColor = true;
            ProductSelectionRadioButton2.CheckedChanged += ProductSelectionRadioButton_CheckedChanged;
            // 
            // ProductSelectionRadioButton1
            // 
            ProductSelectionRadioButton1.AutoSize = true;
            ProductSelectionRadioButton1.Location = new Point(19, 47);
            ProductSelectionRadioButton1.Name = "ProductSelectionRadioButton1";
            ProductSelectionRadioButton1.Size = new Size(184, 36);
            ProductSelectionRadioButton1.TabIndex = 0;
            ProductSelectionRadioButton1.TabStop = true;
            ProductSelectionRadioButton1.Text = "radioButton1";
            ProductSelectionRadioButton1.UseVisualStyleBackColor = true;
            ProductSelectionRadioButton1.CheckedChanged += ProductSelectionRadioButton_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(ColorBlueButton);
            panel1.Controls.Add(ColorPurpleButton);
            panel1.Controls.Add(ColorGreenButton);
            panel1.Controls.Add(ColorRedButton);
            panel1.Location = new Point(602, 1137);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 165);
            panel1.TabIndex = 19;
            // 
            // ColorBlueButton
            // 
            ColorBlueButton.BackColor = Color.FromArgb(192, 255, 255);
            ColorBlueButton.ForeColor = Color.Blue;
            ColorBlueButton.Location = new Point(192, 89);
            ColorBlueButton.Name = "ColorBlueButton";
            ColorBlueButton.Size = new Size(150, 46);
            ColorBlueButton.TabIndex = 3;
            ColorBlueButton.Text = "Blue";
            TechMarketingToolTip.SetToolTip(ColorBlueButton, "Blue");
            ColorBlueButton.UseVisualStyleBackColor = false;
            ColorBlueButton.Click += ColorBlueButton_Click;
            // 
            // ColorPurpleButton
            // 
            ColorPurpleButton.BackColor = Color.FromArgb(255, 192, 255);
            ColorPurpleButton.ForeColor = Color.Fuchsia;
            ColorPurpleButton.Location = new Point(17, 89);
            ColorPurpleButton.Name = "ColorPurpleButton";
            ColorPurpleButton.Size = new Size(150, 46);
            ColorPurpleButton.TabIndex = 2;
            ColorPurpleButton.Text = "Purple";
            TechMarketingToolTip.SetToolTip(ColorPurpleButton, "Purple");
            ColorPurpleButton.UseVisualStyleBackColor = false;
            ColorPurpleButton.Click += ColorPurpleButton_Click;
            // 
            // ColorGreenButton
            // 
            ColorGreenButton.BackColor = Color.FromArgb(192, 255, 192);
            ColorGreenButton.ForeColor = Color.FromArgb(0, 192, 0);
            ColorGreenButton.Location = new Point(192, 23);
            ColorGreenButton.Name = "ColorGreenButton";
            ColorGreenButton.Size = new Size(150, 46);
            ColorGreenButton.TabIndex = 1;
            ColorGreenButton.Text = "Green";
            TechMarketingToolTip.SetToolTip(ColorGreenButton, "Green");
            ColorGreenButton.UseVisualStyleBackColor = false;
            ColorGreenButton.Click += ColorGreenButton_Click;
            // 
            // ColorRedButton
            // 
            ColorRedButton.BackColor = Color.FromArgb(255, 192, 192);
            ColorRedButton.ForeColor = Color.Red;
            ColorRedButton.Location = new Point(17, 23);
            ColorRedButton.Name = "ColorRedButton";
            ColorRedButton.Size = new Size(150, 46);
            ColorRedButton.TabIndex = 0;
            ColorRedButton.Text = "Red";
            TechMarketingToolTip.SetToolTip(ColorRedButton, "Red");
            ColorRedButton.UseVisualStyleBackColor = false;
            ColorRedButton.Click += ColorRedButton_Click;
            // 
            // ProductPictureBox
            // 
            ProductPictureBox.Location = new Point(691, 266);
            ProductPictureBox.Name = "ProductPictureBox";
            ProductPictureBox.Size = new Size(303, 213);
            ProductPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            ProductPictureBox.TabIndex = 14;
            ProductPictureBox.TabStop = false;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(859, 113);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(78, 32);
            DescriptionLabel.TabIndex = 10;
            DescriptionLabel.Text = "label1";
            // 
            // PlugPictureBox
            // 
            PlugPictureBox.Image = Properties.Resources.plug_logo;
            PlugPictureBox.Location = new Point(30, 31);
            PlugPictureBox.Name = "PlugPictureBox";
            PlugPictureBox.Size = new Size(200, 176);
            PlugPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PlugPictureBox.TabIndex = 18;
            PlugPictureBox.TabStop = false;
            // 
            // SalesRepStatusStrip
            // 
            SalesRepStatusStrip.ImageScalingSize = new Size(32, 32);
            SalesRepStatusStrip.Items.AddRange(new ToolStripItem[] { SalesRepStatusStripLabel });
            SalesRepStatusStrip.Location = new Point(0, 1430);
            SalesRepStatusStrip.Name = "SalesRepStatusStrip";
            SalesRepStatusStrip.Size = new Size(2777, 22);
            SalesRepStatusStrip.TabIndex = 13;
            SalesRepStatusStrip.Text = "statusStrip1";
            // 
            // SalesRepStatusStripLabel
            // 
            SalesRepStatusStripLabel.Name = "SalesRepStatusStripLabel";
            SalesRepStatusStripLabel.Size = new Size(408, 32);
            SalesRepStatusStripLabel.Text = "Remember to save this for customer!";
            SalesRepStatusStripLabel.Visible = false;
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Location = new Point(443, 438);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(51, 39);
            QuantityTextBox.TabIndex = 13;
            ExitButtonToolTip.SetToolTip(QuantityTextBox, "Enter a Quanity");
            // 
            // AddToOrderButton
            // 
            AddToOrderButton.Location = new Point(11, 20);
            AddToOrderButton.Name = "AddToOrderButton";
            AddToOrderButton.Size = new Size(249, 46);
            AddToOrderButton.TabIndex = 0;
            AddToOrderButton.Text = "&Add To Order";
            ExitButtonToolTip.SetToolTip(AddToOrderButton, "Add to Order");
            TechMarketingToolTip.SetToolTip(AddToOrderButton, "Add To Order");
            AddToOrderButton.UseVisualStyleBackColor = true;
            AddToOrderButton.Click += AddToOrderButton_Click;
            // 
            // ManagementTotalsButton
            // 
            ManagementTotalsButton.Location = new Point(282, 77);
            ManagementTotalsButton.Name = "ManagementTotalsButton";
            ManagementTotalsButton.Size = new Size(249, 46);
            ManagementTotalsButton.TabIndex = 3;
            ManagementTotalsButton.Text = "&Management Totals";
            TechMarketingToolTip.SetToolTip(ManagementTotalsButton, "Management Totals");
            ManagementTotalsButton.UseVisualStyleBackColor = true;
            ManagementTotalsButton.Click += ManagementTotalsButton_Click;
            // 
            // NewCustomerButton
            // 
            NewCustomerButton.Location = new Point(282, 20);
            NewCustomerButton.Name = "NewCustomerButton";
            NewCustomerButton.Size = new Size(249, 46);
            NewCustomerButton.TabIndex = 2;
            NewCustomerButton.Text = "&New Customer";
            TechMarketingToolTip.SetToolTip(NewCustomerButton, "New Customer");
            NewCustomerButton.UseVisualStyleBackColor = true;
            NewCustomerButton.Click += NewCustomerButton_Click;
            // 
            // EndOrderButton
            // 
            EndOrderButton.Location = new Point(11, 77);
            EndOrderButton.Name = "EndOrderButton";
            EndOrderButton.Size = new Size(249, 46);
            EndOrderButton.TabIndex = 1;
            EndOrderButton.Text = "&End Order";
            TechMarketingToolTip.SetToolTip(EndOrderButton, "End Of Order");
            EndOrderButton.UseVisualStyleBackColor = true;
            EndOrderButton.Click += EndOrderButton_Click;
            // 
            // TestButton
            // 
            TestButton.Location = new Point(980, 1313);
            TestButton.Name = "TestButton";
            TestButton.Size = new Size(150, 46);
            TestButton.TabIndex = 19;
            TestButton.Text = "Test";
            TechMarketingToolTip.SetToolTip(TestButton, "Test");
            TestButton.UseVisualStyleBackColor = true;
            TestButton.Click += TestButton_Click;
            // 
            // CustomerAddressLabel
            // 
            CustomerAddressLabel.AutoSize = true;
            CustomerAddressLabel.Location = new Point(265, 217);
            CustomerAddressLabel.Name = "CustomerAddressLabel";
            CustomerAddressLabel.Size = new Size(172, 32);
            CustomerAddressLabel.TabIndex = 2;
            CustomerAddressLabel.Text = "Street Address:";
            // 
            // CustomerCityLabel
            // 
            CustomerCityLabel.AutoSize = true;
            CustomerCityLabel.Location = new Point(375, 265);
            CustomerCityLabel.Name = "CustomerCityLabel";
            CustomerCityLabel.Size = new Size(60, 32);
            CustomerCityLabel.TabIndex = 4;
            CustomerCityLabel.Text = "City:";
            // 
            // CustomerStateLabel
            // 
            CustomerStateLabel.AutoSize = true;
            CustomerStateLabel.Location = new Point(365, 306);
            CustomerStateLabel.Name = "CustomerStateLabel";
            CustomerStateLabel.Size = new Size(72, 32);
            CustomerStateLabel.TabIndex = 6;
            CustomerStateLabel.Text = "State:";
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Location = new Point(133, 445);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(304, 32);
            QuantityLabel.TabIndex = 12;
            QuantityLabel.Text = "Enter Quantity to Purchase:";
            // 
            // CustomerZipLabel
            // 
            CustomerZipLabel.AutoSize = true;
            CustomerZipLabel.Location = new Point(382, 343);
            CustomerZipLabel.Name = "CustomerZipLabel";
            CustomerZipLabel.Size = new Size(53, 32);
            CustomerZipLabel.TabIndex = 8;
            CustomerZipLabel.Text = "Zip:";
            // 
            // CustomerAddressTextBox
            // 
            CustomerAddressTextBox.Location = new Point(443, 210);
            CustomerAddressTextBox.Name = "CustomerAddressTextBox";
            CustomerAddressTextBox.Size = new Size(200, 39);
            CustomerAddressTextBox.TabIndex = 3;
            // 
            // CustomerCityTextBox
            // 
            CustomerCityTextBox.Location = new Point(443, 258);
            CustomerCityTextBox.Name = "CustomerCityTextBox";
            CustomerCityTextBox.Size = new Size(200, 39);
            CustomerCityTextBox.TabIndex = 5;
            // 
            // CustomerStateTextBox
            // 
            CustomerStateTextBox.Location = new Point(443, 303);
            CustomerStateTextBox.Name = "CustomerStateTextBox";
            CustomerStateTextBox.Size = new Size(51, 39);
            CustomerStateTextBox.TabIndex = 7;
            // 
            // TaxRateGroupBox
            // 
            TaxRateGroupBox.Controls.Add(TaxRateRadioButton3);
            TaxRateGroupBox.Controls.Add(TaxRateRadioButton2);
            TaxRateGroupBox.Controls.Add(TaxRateRadioButton1);
            TaxRateGroupBox.Location = new Point(12, 1002);
            TaxRateGroupBox.Name = "TaxRateGroupBox";
            TaxRateGroupBox.Size = new Size(677, 105);
            TaxRateGroupBox.TabIndex = 15;
            TaxRateGroupBox.TabStop = false;
            TaxRateGroupBox.Text = "Select Tax Type:";
            // 
            // TaxRateRadioButton3
            // 
            TaxRateRadioButton3.AutoSize = true;
            TaxRateRadioButton3.Location = new Point(472, 46);
            TaxRateRadioButton3.Name = "TaxRateRadioButton3";
            TaxRateRadioButton3.Size = new Size(184, 36);
            TaxRateRadioButton3.TabIndex = 2;
            TaxRateRadioButton3.TabStop = true;
            TaxRateRadioButton3.Text = "radioButton3";
            TaxRateRadioButton3.UseVisualStyleBackColor = true;
            TaxRateRadioButton3.CheckedChanged += TaxRateRadioButton_CheckedChanged;
            // 
            // TaxRateRadioButton2
            // 
            TaxRateRadioButton2.AutoSize = true;
            TaxRateRadioButton2.Location = new Point(241, 45);
            TaxRateRadioButton2.Name = "TaxRateRadioButton2";
            TaxRateRadioButton2.Size = new Size(184, 36);
            TaxRateRadioButton2.TabIndex = 1;
            TaxRateRadioButton2.TabStop = true;
            TaxRateRadioButton2.Text = "radioButton2";
            TaxRateRadioButton2.UseVisualStyleBackColor = true;
            TaxRateRadioButton2.CheckedChanged += TaxRateRadioButton_CheckedChanged;
            // 
            // TaxRateRadioButton1
            // 
            TaxRateRadioButton1.AutoSize = true;
            TaxRateRadioButton1.Location = new Point(18, 46);
            TaxRateRadioButton1.Name = "TaxRateRadioButton1";
            TaxRateRadioButton1.Size = new Size(184, 36);
            TaxRateRadioButton1.TabIndex = 0;
            TaxRateRadioButton1.TabStop = true;
            TaxRateRadioButton1.Text = "radioButton1";
            TaxRateRadioButton1.UseVisualStyleBackColor = true;
            TaxRateRadioButton1.CheckedChanged += TaxRateRadioButton_CheckedChanged;
            // 
            // DiscountCheckBox
            // 
            DiscountCheckBox.AutoSize = true;
            DiscountCheckBox.Location = new Point(706, 1071);
            DiscountCheckBox.Name = "DiscountCheckBox";
            DiscountCheckBox.Size = new Size(249, 36);
            DiscountCheckBox.TabIndex = 31;
            DiscountCheckBox.Text = "Check for Discount";
            DiscountCheckBox.UseVisualStyleBackColor = true;
            // 
            // AdministrativePanel
            // 
            AdministrativePanel.BorderStyle = BorderStyle.Fixed3D;
            AdministrativePanel.Controls.Add(ManagementTotalsButton);
            AdministrativePanel.Controls.Add(NewCustomerButton);
            AdministrativePanel.Controls.Add(EndOrderButton);
            AdministrativePanel.Controls.Add(AddToOrderButton);
            AdministrativePanel.Location = new Point(18, 1149);
            AdministrativePanel.Name = "AdministrativePanel";
            AdministrativePanel.Size = new Size(546, 140);
            AdministrativePanel.TabIndex = 17;
            // 
            // PackagingOptionsGroupBox
            // 
            PackagingOptionsGroupBox.Controls.Add(PackagingOptionsCheckBox4);
            PackagingOptionsGroupBox.Controls.Add(PackagingOptionsCheckBox3);
            PackagingOptionsGroupBox.Controls.Add(PackagingOptionsCheckBox2);
            PackagingOptionsGroupBox.Controls.Add(PackagingOptionsCheckBox1);
            PackagingOptionsGroupBox.Location = new Point(12, 1295);
            PackagingOptionsGroupBox.Name = "PackagingOptionsGroupBox";
            PackagingOptionsGroupBox.Size = new Size(955, 116);
            PackagingOptionsGroupBox.TabIndex = 16;
            PackagingOptionsGroupBox.TabStop = false;
            PackagingOptionsGroupBox.Text = "Select Any Packaging Options:";
            // 
            // PackagingOptionsCheckBox4
            // 
            PackagingOptionsCheckBox4.AutoSize = true;
            PackagingOptionsCheckBox4.Location = new Point(716, 54);
            PackagingOptionsCheckBox4.Name = "PackagingOptionsCheckBox4";
            PackagingOptionsCheckBox4.Size = new Size(159, 36);
            PackagingOptionsCheckBox4.TabIndex = 3;
            PackagingOptionsCheckBox4.Text = "checkBox4";
            PackagingOptionsCheckBox4.UseVisualStyleBackColor = true;
            // 
            // PackagingOptionsCheckBox3
            // 
            PackagingOptionsCheckBox3.AutoSize = true;
            PackagingOptionsCheckBox3.Location = new Point(472, 54);
            PackagingOptionsCheckBox3.Name = "PackagingOptionsCheckBox3";
            PackagingOptionsCheckBox3.Size = new Size(159, 36);
            PackagingOptionsCheckBox3.TabIndex = 2;
            PackagingOptionsCheckBox3.Text = "checkBox3";
            PackagingOptionsCheckBox3.UseVisualStyleBackColor = true;
            // 
            // PackagingOptionsCheckBox2
            // 
            PackagingOptionsCheckBox2.AutoSize = true;
            PackagingOptionsCheckBox2.Location = new Point(220, 54);
            PackagingOptionsCheckBox2.Name = "PackagingOptionsCheckBox2";
            PackagingOptionsCheckBox2.Size = new Size(159, 36);
            PackagingOptionsCheckBox2.TabIndex = 1;
            PackagingOptionsCheckBox2.Text = "checkBox2";
            PackagingOptionsCheckBox2.UseVisualStyleBackColor = true;
            // 
            // PackagingOptionsCheckBox1
            // 
            PackagingOptionsCheckBox1.AutoSize = true;
            PackagingOptionsCheckBox1.Location = new Point(6, 54);
            PackagingOptionsCheckBox1.Name = "PackagingOptionsCheckBox1";
            PackagingOptionsCheckBox1.Size = new Size(159, 36);
            PackagingOptionsCheckBox1.TabIndex = 0;
            PackagingOptionsCheckBox1.Text = "checkBox1";
            PackagingOptionsCheckBox1.UseVisualStyleBackColor = true;
            // 
            // CustomerZipMaskedTextBox
            // 
            CustomerZipMaskedTextBox.Location = new Point(443, 348);
            CustomerZipMaskedTextBox.Mask = "00000";
            CustomerZipMaskedTextBox.Name = "CustomerZipMaskedTextBox";
            CustomerZipMaskedTextBox.Size = new Size(111, 39);
            CustomerZipMaskedTextBox.TabIndex = 9;
            CustomerZipMaskedTextBox.ValidatingType = typeof(int);
            // 
            // ReceiptLabel
            // 
            ReceiptLabel.AutoSize = true;
            ReceiptLabel.Font = new Font("Courier New", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            ReceiptLabel.Location = new Point(1130, 279);
            ReceiptLabel.Name = "ReceiptLabel";
            ReceiptLabel.Size = new Size(0, 30);
            ReceiptLabel.TabIndex = 32;
            // 
            // TechMarketingForm
            // 
            AcceptButton = AddToOrderButton;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = ExitButton;
            ClientSize = new Size(2777, 1452);
            Controls.Add(ReceiptLabel);
            Controls.Add(CustomerZipMaskedTextBox);
            Controls.Add(PackagingOptionsGroupBox);
            Controls.Add(AdministrativePanel);
            Controls.Add(DiscountCheckBox);
            Controls.Add(TaxRateGroupBox);
            Controls.Add(QuantityTextBox);
            Controls.Add(CustomerStateTextBox);
            Controls.Add(CustomerCityTextBox);
            Controls.Add(CustomerAddressTextBox);
            Controls.Add(CustomerZipLabel);
            Controls.Add(QuantityLabel);
            Controls.Add(CustomerStateLabel);
            Controls.Add(CustomerCityLabel);
            Controls.Add(CustomerAddressLabel);
            Controls.Add(TestButton);
            Controls.Add(SalesRepStatusStrip);
            Controls.Add(PlugPictureBox);
            Controls.Add(DescriptionLabel);
            Controls.Add(ProductPictureBox);
            Controls.Add(panel1);
            Controls.Add(ProductSelectionGroupBox);
            Controls.Add(CustomerPhoneNumberMaskedTextBox);
            Controls.Add(ConnectWithUsLabel);
            Controls.Add(CustomerNameTextBox);
            Controls.Add(PhoneNumberLabel);
            Controls.Add(CustomerNameLabel);
            Controls.Add(ExitButton);
            Name = "TechMarketingForm";
            Text = "GUI Prg #4 Tech Marketing        Caleb Huyser";
            Load += TechMarketingForm_Load;
            ProductSelectionGroupBox.ResumeLayout(false);
            ProductSelectionGroupBox.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlugPictureBox).EndInit();
            SalesRepStatusStrip.ResumeLayout(false);
            SalesRepStatusStrip.PerformLayout();
            TaxRateGroupBox.ResumeLayout(false);
            TaxRateGroupBox.PerformLayout();
            AdministrativePanel.ResumeLayout(false);
            PackagingOptionsGroupBox.ResumeLayout(false);
            PackagingOptionsGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ExitButton;
        private Label CustomerNameLabel;
        private Label PhoneNumberLabel;
        private TextBox CustomerNameTextBox;
        private Label ConnectWithUsLabel;
        private MaskedTextBox CustomerPhoneNumberMaskedTextBox;
        private GroupBox ProductSelectionGroupBox;
        private RadioButton ProductSelectionRadioButton1;
        private RadioButton ProductSelectionRadioButton5;
        private RadioButton ProductSelectionRadioButton4;
        private RadioButton ProductSelectionRadioButton3;
        private RadioButton ProductSelectionRadioButton2;
        private Panel panel1;
        private Button ColorBlueButton;
        private Button ColorPurpleButton;
        private Button ColorGreenButton;
        private Button ColorRedButton;
        private PictureBox ProductPictureBox;
        private Label DescriptionLabel;
        private PictureBox PlugPictureBox;
        private StatusStrip SalesRepStatusStrip;
        private ToolStripStatusLabel SalesRepStatusStripLabel;
        private ToolTip ResetButtonToolTip;
        private ToolTip ExitButtonToolTip;
        private Button TestButton;
        private ToolTip TechMarketingToolTip;
        private Label CustomerAddressLabel;
        private Label CustomerCityLabel;
        private Label CustomerStateLabel;
        private Label QuantityLabel;
        private Label CustomerZipLabel;
        private TextBox CustomerAddressTextBox;
        private TextBox CustomerCityTextBox;
        private TextBox CustomerStateTextBox;
        private TextBox QuantityTextBox;
        private GroupBox TaxRateGroupBox;
        private RadioButton TaxRateRadioButton3;
        private RadioButton TaxRateRadioButton2;
        private RadioButton TaxRateRadioButton1;
        private CheckBox DiscountCheckBox;
        private Panel AdministrativePanel;
        private GroupBox PackagingOptionsGroupBox;
        private CheckBox PackagingOptionsCheckBox4;
        private CheckBox PackagingOptionsCheckBox3;
        private CheckBox PackagingOptionsCheckBox2;
        private CheckBox PackagingOptionsCheckBox1;
        private MaskedTextBox CustomerZipMaskedTextBox;
        private Button ManagementTotalsButton;
        private Button NewCustomerButton;
        private Button EndOrderButton;
        private Button AddToOrderButton;
        private Label ReceiptLabel;
    }
}