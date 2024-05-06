// Programmer:  Caleb Huyser
// Class:       CIS207-10228
// Date Due:    10/28/23
// Assignment:  Programming Assignment #4
//
// Description: This program builds up programming assignment 2. It showcases beginning OOP programming. It is funtionaly the same
// as assignment 2. 
//
//*****************************************************************************

using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
namespace HuyserCG1
{
    public partial class TechMarketingForm : Form
    {
        public TechMarketingForm()
        {
            InitializeComponent();
        }
        // VARIABLLE DECLARATIONS*******************************************************************************

        // INPUT VARIABLES

        // Product quuantity entered by customer
        private int quantityInt = 0;

        // Price of product selected by customer
        private decimal productPriceDecimal = 0.0m;

        // Empty array to hold packaging options checkbox controls
        private CheckBox[] packagingCheckBoxArray = new CheckBox[4];

        //WORKING VARIABLES

        // Holds the object of the selected radio buttons
        // Product selection radio buttons
        private RadioButton selectedRadioButtonProductSelection = new();

        // Taxrate radio buttons
        private RadioButton selectedRadioButtonTaxRate = new();

        // Holds the selected products name
        private string productNameString = " ";

        // Empty instantiation for form load
        CustomerClass aCustomer = new CustomerClass();

        //END VARIABLE DECLARATIONS******************************************************************************

        /*
         * private void TechMarketingForm_Load(object sender, EventArgs e)
         * 
         * Summary:
         *    Called on form load. Sets the form up for data entry by user.
         *    
        */
        private void TechMarketingForm_Load(object sender, EventArgs e)
        {
            // All of the following code until end of method runs at form load*************************************

            // Sets ProductSelectionRadioButton1 text property,
            // concatenates  product 1 constant onto end of string
            ProductSelectionRadioButton1.Text = "Apple Thunderbolt(USB - C) To Thunderbolt 2 Adapter for $" +
                                                aCustomer.Product1Price.ToString();

            // Sets ProductSelectionRadioButton2 text property,
            // concatenates  product 2 constant onto end of string
            ProductSelectionRadioButton2.Text = "Apple Lighting to VGA Adapter for $" +
                                                aCustomer.Product2Price.ToString();

            // Sets ProductSelectionRadioButton3 text property,
            // concatenates  product 3 constant onto end of string
            ProductSelectionRadioButton3.Text = "Apple USB Cable Adapter for $" +
                                                aCustomer.Product3Price.ToString();

            // Sets ProductSelectionRadioButton4 text property,
            // concatenates  product 4 constant onto end of string
            ProductSelectionRadioButton4.Text = "Apple USB-C VGA Multiport Adapter for $" +
                                                aCustomer.Product4Price.ToString();

            // Sets ProductSelectionRadioButton5 text property,
            // concatenates  product 5 constant onto end of string
            ProductSelectionRadioButton5.Text = "Dynex Mini Display port to HDMI Adapter for $" +
                                                aCustomer.Product5Price.ToString();

            // Sets ProductSelectionRadioButton1 tag to PRODUCT1_PRICE_DECIMAL constant
            ProductSelectionRadioButton1.Tag = aCustomer.Product1Price;

            // Sets ProductSelectionRadioButton2 tag to PRODUCT2_PRICE_DECIMAL constant
            ProductSelectionRadioButton2.Tag = aCustomer.Product2Price;

            // Sets ProductSelectionRadioButton3 tag to PRODUCT3_PRICE_DECIMAL constant
            ProductSelectionRadioButton3.Tag = aCustomer.Product3Price;

            // Sets ProductSelectionRadioButton4 tag to PRODUCT4_PRICE_DECIMAL constant
            ProductSelectionRadioButton4.Tag = aCustomer.Product4Price;

            // Sets ProductSelectionRadioButton5 tag to PRODUCT5_PRICE_DECIMAL constant
            ProductSelectionRadioButton5.Tag = aCustomer.Product5Price;

            // Sets TaxRateRadioButton1 text property
            TaxRateRadioButton1.Text = "Business";

            // Sets TaxRateRadioButton2 text property
            TaxRateRadioButton2.Text = "Personal";

            // Sets TaxRateRadioButton3 text property
            TaxRateRadioButton3.Text = "For Resale";

            // Sets PackagingOptionsCheckBox1 text property
            PackagingOptionsCheckBox1.Text = "Boxes $" + aCustomer.PackagingOption1.ToString();

            // Sets PackagingOptionsCheckBox2 text property
            PackagingOptionsCheckBox2.Text = "Padding $" + aCustomer.PackagingOption2.ToString();

            // Sets PackagingOptionsCheckBox3 text property
            PackagingOptionsCheckBox3.Text = "Delivery $" + aCustomer.PackagingOption3.ToString();

            // Sets PackagingOptionsCheckBox4 text property
            PackagingOptionsCheckBox4.Text = "Wrapping $" + aCustomer.PackagingOption4.ToString();

            // Sets TaxRateRadioButton1 tag to BUSINESS_TAXRATE_DECIMAL constant
            TaxRateRadioButton1.Tag = aCustomer.Taxrate1;

            // Sets TaxRateRadioButton2 tag to PERSONAL_TAXRATE_DECIMAL constant
            TaxRateRadioButton2.Tag = aCustomer.Taxrate2;

            // Sets TaxRateRadioButton3 tag to RESALE_TAXRATE_DECIMAL constant
            TaxRateRadioButton3.Tag = aCustomer.Taxrate3;

            // Sets PackagingOptionsCheckBox tag property to BOX_PRICE_DECIMAL constant
            PackagingOptionsCheckBox1.Tag = aCustomer.PackagingOption1;

            // Sets PackagingOptionsCheckBox tag property to PADDING_PRICE_DECIMAL constant
            PackagingOptionsCheckBox2.Tag = aCustomer.PackagingOption2;

            // Sets PackagingOptionsCheckBox tag property to DELIVERY_PRICE_DECIMAL constant
            PackagingOptionsCheckBox3.Tag = aCustomer.PackagingOption3;

            // Sets PackagingOptionsCheckBox tag property to WRAPPING_PRICE_DECIMAL constant
            PackagingOptionsCheckBox4.Tag = aCustomer.PackagingOption4;

            // Resets form labels
            ResetLabels();

            // Disable end order button until an item has been added to order
            EndOrderButton.Enabled = false;

            // Disable management totals button until end of order has been calculated
            ManagementTotalsButton.Enabled = false;

            // Disables new customer button until after end of order has been calculated
            NewCustomerButton.Enabled = false;

            // Assigns each packaging array checkbox to a spot in the array
            packagingCheckBoxArray[0] = PackagingOptionsCheckBox1;

            packagingCheckBoxArray[1] = PackagingOptionsCheckBox2;

            packagingCheckBoxArray[2] = PackagingOptionsCheckBox3;

            packagingCheckBoxArray[3] = PackagingOptionsCheckBox4;

            // Activates form
            this.Activate();

            // End method *********************************************************************************************
        }

        /*
        * private void DisplayLineItem()
        * 
        * Summary:
        *   Displays each line total on the form. 
        * Inputs:
        *   None
        * Outputs:
        *   None - void 
        * Return:
        *   None
        *   
        */
        private void DisplayLineItem()
        {
            // Outputs heading only 1 time for each customer
            // If statements tests if a heading is already written
            if (ReceiptLabel.Text == string.Empty)
            {
                // Writes initial heading
                ReceiptLabel.Text = "Connect With Us!" + "Date: ".PadLeft(15) + DateTime.Now.ToShortDateString().PadLeft(5) + "Customer Phone: ".PadLeft(30) +
                                    CustomerPhoneNumberMaskedTextBox.Text +
                                    Environment.NewLine + "Receipt for: " + CustomerNameTextBox.Text + Environment.NewLine;

                // Writes customer information onto form
                ReceiptLabel.Text +=
                                    CustomerAddressTextBox.Text.PadLeft(28) + Environment.NewLine +
                                    CustomerCityTextBox.Text.PadLeft(21) + ", " + CustomerStateTextBox.Text + CustomerZipMaskedTextBox.Text.PadLeft(10) +
                                    Environment.NewLine + Environment.NewLine +
                                    "Quantity".PadLeft(10) + "Description".PadLeft(15) + "Unit Price".PadLeft(55) + "Extended Price".PadLeft(20) +
                                    Environment.NewLine + "".PadRight(100, '-') + Environment.NewLine;
            }

            // Writes calculated values to form
            ReceiptLabel.Text +=
                                quantityInt.ToString("n0").PadLeft(10) + "    " +
                                productNameString.PadRight(55) +
                                productPriceDecimal.ToString("n2").PadLeft(11) +
                                aCustomer.Total.ToString("n2").PadLeft(20) +
                                Environment.NewLine;

            // Clears quantity for next item purchase
            QuantityTextBox.Clear();

            // Clears product radio button for next product purchase
            ResetProductSelectionRadioButtons();

            // Clears picture box for next product purchase
            ProductPictureBox.Image = null;

            // Clears description label for next product purchase 
            DescriptionLabel.Text = string.Empty;
        }

        /*
        * private void DisplayEndOfOrder()
        * 
        * Summary:
        *   Displays all end of order totals on the form.
        * Inputs:
        *   None
        * Outputs:
        *   None - void 
        * Return:
        *   None
        *   
        */
        private void DisplayEndOfOrder()
        {
            // Writes out final totals to form
            ReceiptLabel.Text +=
                                Environment.NewLine +
                                Environment.NewLine +
                                "FINAL TOTALS:" +
                                Environment.NewLine +
                                "".PadRight(65, '-') +
                                Environment.NewLine +
                                "Number of Items:".PadRight(20) + aCustomer.TotalItems.ToString().PadLeft(20) +
                                Environment.NewLine +
                                "Final Amount Due:".PadRight(20) + aCustomer.TotalAmountDue.ToString("c").PadLeft(20) +
                                Environment.NewLine +
                                aCustomer.Discount +
                                "Tax Amount is:".PadRight(20) + aCustomer.TaxAmountDue.ToString("c").PadLeft(20) +
                                " at " + aCustomer.TaxRate.ToString("p") + " for " + aCustomer.TaxType + " tax type" +
                                Environment.NewLine +
                                "Packaging Charge:".PadRight(20) + aCustomer.PackagingAmountDue.ToString("c").PadLeft(20) +
                                Environment.NewLine +
                                "Final Total Due is:".PadRight(20) + aCustomer.FinalTotal.ToString("c").PadLeft(20) +
                                Environment.NewLine +
                                Environment.NewLine;

            ReceiptLabel.Text += aCustomer.Packaging;

            ReceiptLabel.Text += Environment.NewLine + "Thank you for your business and have a great day! " + CustomerNameTextBox.Text;
        }

        /*
        * private void ResetForNewCustomer()
        * 
        * Summary:
        *   The ResetForNewCustomers() method resets all labels, buttons, 
        *   checkboxes, and varaibles used for total and fees calculations
        *   for a new customer. Counts total # of customers 
        * Inputs:
        *   None
        * Outputs:
        *   None - void 
        * Return:
        *   None
        *   
        */
        private void ResetForNewCustomer()
        {
            // Clears customer name for next customer
            CustomerNameTextBox.Clear();

            // Clears customer addres for next customer
            CustomerAddressTextBox.Clear();

            // Clears customer city for next customer
            CustomerCityTextBox.Clear();

            // Clears customer state for next customer
            CustomerStateTextBox.Clear();

            // Clears customer zipcode for next customer
            CustomerZipMaskedTextBox.Clear();

            // Clears customer phone number for next customer
            CustomerPhoneNumberMaskedTextBox.Clear();

            // Clears quantity for next customer
            QuantityTextBox.Clear();

            // Resets product selection radio buttons for next customer
            ResetProductSelectionRadioButtons();

            // Resets all labels on the form for next customer
            ResetLabels();

            // Unchecks discount checkbox for next customer
            DiscountCheckBox.Checked = false;

            // Resets description back label color
            DescriptionLabel.BackColor = Color.White;

            // Resets description label fore color
            DescriptionLabel.ForeColor = Color.Black;

            // Resets tax rate radio buttons for new customer ******
            TaxRateRadioButton1.Checked = true;

            TaxRateRadioButton1.Checked = false;
            // *****************************************************

            // Unchecks packaging options for next customer ********
            PackagingOptionsCheckBox1.Checked = false;

            PackagingOptionsCheckBox2.Checked = false;

            PackagingOptionsCheckBox3.Checked = false;

            PackagingOptionsCheckBox4.Checked = false;
            // *****************************************************

            // Enables addd to order button for next customer
            AddToOrderButton.Enabled = true;

            // Disables end order button until a line total is
            // run again
            EndOrderButton.Enabled = false;

            NewCustomerButton.Enabled = false;

            // Zeros quanity entered for new customer calculations
            quantityInt = 0;

            // Sets product name string to empty for new customer
            productNameString = string.Empty;

            // Sets packaging options to empty for new customer
            //packagingOptionString = string.Empty;

            // Focuses customer name for next cutomer
            CustomerNameTextBox.Focus();

            // Instantiates an object that clears variables for totaling for each customer
            CustomerClass aSale = new CustomerClass("ClearCUST"); 
        }

        /*
        * private void ResetLabels()
        * 
        * Summary:
        *   The ResetLabels() method resets all labels on the form. 
        * Inputs:
        *   None
        * Outputs:
        *   None - void 
        * Return:
        *   None
        *   
        */
        private void ResetLabels()
        {
            // Sets ProductPictureBox image property to null, hiding it
            ProductPictureBox.Image = null;

            // Resets the DescriptionLabel text property
            DescriptionLabel.ResetText();

            // Resets the ReceiptLabel text property
            ReceiptLabel.ResetText();

            // Sets DesccriptionLabel back color to white
            DescriptionLabel.BackColor = Color.White;

            // Sets DescriptionLabel fore color to black
            DescriptionLabel.ForeColor = Color.Black;
        }

        /*
        * private void ResetProductSelectionRadioButtons()
        * 
        * Summary:
        *   Resets the ProductSelectionRadioButtons on the form.
        * Inputs:
        *   None
        * Outputs:
        *   None - void 
        * Return:
        *   None
        *   
        */
        private void ResetProductSelectionRadioButtons()
        {
            // Sets ProductSelectionRadioButton1 to true
            ProductSelectionRadioButton1.Checked = true;

            // Sets ProductSelectionRadioButton1 to false
            ProductSelectionRadioButton1.Checked = false;
        }

        /*
        * private void ShowError(string msg, string title, GroupBox gb)
        * 
        * Summary:
        *   Checks if data input on form is good and satisfys the requirements to perform calculations. 
        *   Calls showerror method if a data check fails.
        * Inputs:
        *   None
        * Outputs:
        *   Bool - true or false
        * Return:
        *   True if all input is good
        *   False if one input check fails
        *   
        */
        private bool ValidInput()
        {
            // Frst Input - Customer Name - Check that a name has been entered, Remove whitespace
            if (CustomerNameTextBox.Text.Trim() != string.Empty)
            {
                // Second Input - Customer Address - Check that an addrass been entered, Remove whitespace
                if (CustomerAddressTextBox.Text.Trim() != string.Empty)
                {
                    // Third Input - Customer City - Check that a city has been entered, Remove whitespace
                    if (CustomerCityTextBox.Text.Trim() != string.Empty)
                    {
                        // Fourth Input - Customer State - Check that a state has been entered and that it is only 2 characters, Remove whitespace
                        if ((CustomerStateTextBox.Text.Trim() != string.Empty) && (CustomerStateTextBox.Text.Trim().Length == 2))
                        {
                            // Fifth Input - Customer Zip - Check that a full zipcode has been entered
                            if (CustomerZipMaskedTextBox.MaskCompleted)
                            {
                                // Sixth Input - Customer Phone Number - Check that a full phone number has been entered
                                if (CustomerPhoneNumberMaskedTextBox.MaskCompleted)
                                {
                                    // Seventh Input - Product Quantity - Convert Product Quantity string to int then test if its greater than zero, Remove whitespace
                                    if ((int.TryParse(QuantityTextBox.Text.Trim(), out quantityInt)) && (quantityInt > 0))
                                    {
                                        // Eighth Input - Product Selection - Checks if a product has been selected
                                        if (ProductSelectionRadioButton1.Checked || ProductSelectionRadioButton2.Checked || ProductSelectionRadioButton3.Checked || ProductSelectionRadioButton4.Checked || ProductSelectionRadioButton5.Checked)
                                        {
                                            // Ninth Input - Tax Rate - A taxrate must be selected, everyone pays taxes
                                            if (TaxRateRadioButton1.Checked || TaxRateRadioButton2.Checked || TaxRateRadioButton3.Checked)
                                            {
                                                // Returns true if all input check pass
                                                return true;
                                            }
                                            else
                                            {
                                                // Calls showError method if a taxrate is not selected
                                                ShowError("Pick a Taxrate Please, everyone pays taxes!", "TAXRATE INPUT ERROR", TaxRateGroupBox);
                                            }
                                        }
                                        else
                                        {
                                            // Calls show error if a product is not selected
                                            ShowError("Select a Connector Please", "CONNECTOR INPUT ERROR", ProductSelectionGroupBox);
                                        }
                                    }
                                    else
                                    {
                                        // Calls showError method if a quanity is not a whole number
                                        ShowError("Enter Quantity of Item as a Whole # Please", "QUANTITY INPUT ERROR", QuantityTextBox);
                                    }
                                }
                                else
                                {
                                    // Calls showError method if no phone number is entered or an incomeplete one is entered
                                    ShowError("Enter a Phone Number Please", "PHONE NUMBER INPUT ERROR", CustomerPhoneNumberMaskedTextBox);
                                }
                            }
                            else
                            {
                                // Calls showError method if a zipcode is not entered or an incomplete one is entered
                                ShowError("Enter a Zip Code Please", "ZIP CODE INPUT ERROR", CustomerZipMaskedTextBox);
                            }
                        }
                        else
                        {
                            // Calls showError method if a full state abbreviation is not entered
                            ShowError("Enter a full state abbreveation", "STATE INPUT ERROR", CustomerStateTextBox);
                        }
                    }
                    else
                    {
                        // Calls showError method if an empty city is entered 
                        ShowError("Enter a City", "CITY INPUT ERROR", CustomerCityTextBox);
                    }
                }
                else
                {
                    // Calls showError method if an empty address is entered
                    ShowError("Enter an Address Please", "ADDRESS INPUT ERROR", CustomerAddressTextBox);
                }
            }
            else
            {
                // Calls showError method if an empty name entered
                ShowError("Enter a Name Please", "NAME INPUT ERROR", CustomerNameTextBox);
            }
            // Returns false if input check fails
            return false;
        }

        /*
        * private void ShowError(string msg, string title, TextBox tb)
        * 
        * Summary:
        *   Opens a message box on error of text box on form
        * Inputs:
        *   Message box message as string
        *   Message box title as string
        *   Text box control as tb
        * Outputs:
        *   None - void 
        * Return:
        *   None
        *   
        */
        private void ShowError(string msg, string title, TextBox tb)
        {
            // FOR NORMAL TEXT BOXES
            // Opens a message box with msg and title set to method inputs when called
            // Sets message box button to ok and message box icon to error
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            // Focuses text box where method was called
            tb.Focus();
            // Selects all input in text box where method was called
            tb.SelectAll();
        }

        /*
        * private void ShowError(string msg, string title, MaskedTextBox mtb)
        * 
        * Summary:
        *   Opens a message box on error of masked text box on form
        * Inputs:
        *   Message box message as string
        *   Message box title as string
        *   Masked text box control as mtb
        * Outputs:
        *   None - void 
        * Return:
        *   None
        *   
        */
        private void ShowError(string msg, string title, MaskedTextBox mtb)
        {
            // FOR MASKED TEXT BOXES
            // Opens a message box with msg and title set to method inputs when called
            // Sets message box button to ok and message box icon to error
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            // Focuses masked text box where method was called
            mtb.Focus();
            // Selects all input in masked text box where method was called
            mtb.SelectAll();
        }

        /*
         * private void ShowError(string msg, string title, GroupBox gb)
         * 
         * Summary:
         *   Opens a message box on error of group box on form.
         * Inputs:
         *   Message box message as string
         *   Message box title as string
         *   Groupbox control as gb
         * Outputs:
         *   None - void 
         * Return:
         *   None
         *   
         */
        private void ShowError(string msg, string title, GroupBox gb)
        {
            // FOR GROUPBOX
            // Opens a message box with msg and title set to method inputs when called
            // Sets message box button to ok and message box icon to error
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            // Sets group box back color property to red where method was called
            gb.BackColor = Color.Red;
            // Focuses masked text box where method was called
            gb.Focus();
        }

        /*
         * private void AddToOrderButton_Click(object sender, EventArgs e)
         * 
         * Summary:
         *   Waits for valid input to return true. Trys running calulations for totals, 
         *   discounts, taxes, and packoing fees.
         *   If an error arises an error is shown to the user. Called on AddToOrderButton click.   
         */
        private void AddToOrderButton_Click(object sender, EventArgs e)
        {
            // If statement tests if all input entered is good.
            // If entered input does not validate shows an error
            if (ValidInput())
            {
                // Try block tests if line total, tax amount due calculation,
                // packaging fee calculation, totals accumulate,
                // discount calculation, and line items display run properly
                try
                {
                    // Gets the quanity input from the form
                    quantityInt = Convert.ToInt32(QuantityTextBox.Text);

                    // Instantiates an object for the customer. Passes relevent fields from the form
                    CustomerClass aSale = new CustomerClass(quantityInt, 
                                                    productPriceDecimal, 
                                                    DiscountCheckBox, 
                                                    selectedRadioButtonTaxRate,
                                                    packagingCheckBoxArray);

                    // Displays each line total
                    DisplayLineItem();

                    // Enables end of order button after one line total
                    EndOrderButton.Enabled = true;

                    // Enables button for new customer
                    NewCustomerButton.Enabled = true;
                }
                // Catches an exception if output or a calculation fail
                catch (Exception CalculationException)
                {
                    MessageBox.Show("" +
                                     Environment.NewLine + CalculationException.Message,
                                     "CALC OR OUTPUT ERROR",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                }
            }
        }

        /*
        * private void EndOrderButton_Click(object sender, EventArgs e)
        * 
        * Summary:
        *     
        *     
        */
        private void EndOrderButton_Click(object sender, EventArgs e)
        {
            // Trys block tests if end of order totals output correctly
            // and management totals total correctly
            try
            {
                // Instantiates an object that calculates the end of order totals on the form
                CustomerClass aSale = new CustomerClass("EndORDER");

                // Displays end of order totals
                DisplayEndOfOrder();
            }
            catch (Exception FinalTotalsException)
            {
                MessageBox.Show("Final total or Mgmt total error!" +
                             FinalTotalsException.Message, "TOTALS ERROR");
            }


            // Disables add to order button after final totals are displayed
            AddToOrderButton.Enabled = false;

            // Disables end order button after a final total is calculated
            EndOrderButton.Enabled = false;

            // Enables management totals button after first accumulation
            ManagementTotalsButton.Enabled = true;
        }

        /*
        * private void NewCustomerButton_Click(object sender, EventArgs e)
        * 
        * Summary:
        *    Calls ResetForNewCustomer method. Runs on click of 
        *    NewCustomerButton on form.
        *                
        */
        private void NewCustomerButton_Click(object sender, EventArgs e)
        {
            // Resets form for new customer
            ResetForNewCustomer();
        }

        /*
        * private void ManagementTotalsButton_Click(object sender, EventArgs e)
        * 
        * Summary:
        *    Shows a summary of management totals in a dialog box. Called on
        *    ManagementTotalsButton click.
        *                
        */
        private void ManagementTotalsButton_Click(object sender, EventArgs e)
        {
            // Hold selected button from dialog box
            DialogResult clearMgmtTotalsDialogResult;

            // Try block checks for succesful accumulation of Mgmt totals and that the dialog box
            // containing them is displayed
            try
            {
                // Hold outs of headings for Mgmt totals 
                string mgmtTotalsString = "Management Totals" +
                                          Environment.NewLine +
                                          "".PadRight(20, '-') +
                                          Environment.NewLine +
                                          "# Customers: " + aCustomer.MgmtTotalCustomer.ToString("n0") + Environment.NewLine +
                                          "# Discounts: " + aCustomer.MgmtTotalDiscounts.ToString("n0") + Environment.NewLine +
                                          "Amount Due: " + aCustomer.MgmtTotal.ToString("c") +
                                          Environment.NewLine +
                                          Environment.NewLine +
                                          Environment.NewLine +
                                          "Click YES Button to Clear Totals";

                // Opens YES/NO dialog box
                clearMgmtTotalsDialogResult = MessageBox.Show(mgmtTotalsString, "MANAGEMENT TOTALS",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question,
                                   MessageBoxDefaultButton.Button2);

                // If statement checks for YES button click
                if (clearMgmtTotalsDialogResult == DialogResult.Yes)
                {
                    // Instantiates an object that clears the management totals variables
                    CustomerClass aSale = new CustomerClass("ClearMGMT");

                    // Disables end order button
                    EndOrderButton.Enabled = false;

                    // Disables Mgmt totals button
                    ManagementTotalsButton.Enabled = false;
                }
            }
            // Shows error box if an error during mgmt totals calc or totals dialog box display
            catch (Exception MgmtTotalsException)
            {
                MessageBox.Show("Mgmt totals error!" +
                                MgmtTotalsException.Message, "MGMT TOTALS RUNTIME ERROR");
            }
        }

        /*
        * private void ProductSelectionRadioButton_CheckedChanged(object sender, EventArgs e)
        * 
        * Summary:
        *     Product selection radio button event handler. Called on product radio button click. 
        *     Shared event handler between each radio button in ProductSelectionGroupBox. 
        *     Uses a switch to determine which radio button is selected. Sets 
        *     ProductPictureBox image property and DescriptionLabel text property 
        *     to relevent product information based on selection. 
        *     
        */
        private void ProductSelectionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Sets selectedRadioButtonProductSelection variable to the
            // clicked radio button in the product selection group box on the form
            selectedRadioButtonProductSelection = (RadioButton)sender;

            // Sets ProductSelectionGroupBox back color to transparent
            ProductSelectionGroupBox.BackColor = Color.Transparent;

            // Used as an index in substring calculations below to remove everything after "for"
            // in product selection radio buttons text property
            int characterIndexInt = 0;

            // Switch determines which product radio button is
            // selected by comparing radiobutton name to each case
            switch (selectedRadioButtonProductSelection.Name)
            {
                case "ProductSelectionRadioButton1":

                    // Sets SelectedProductPriceDecimal variable to the
                    // currently selected products price
                    productPriceDecimal = (decimal)ProductSelectionRadioButton1.Tag;

                    // Int value assigned to f in product name string
                    characterIndexInt = ProductSelectionRadioButton1.Text.IndexOf("f");

                    // Takes a sub string of product name string starting at the
                    // begining and going to the index of f
                    productNameString = ProductSelectionRadioButton1.Text.Substring(0, characterIndexInt);

                    // Sets ProductPictureBox image property to
                    // Apple_Thunderbolt__USB_C__To_Thunderbolt_2_Adapter
                    ProductPictureBox.Image = Properties.Resources.Apple_Thunderbolt__USB_C__To_Thunderbolt_2_Adapter;

                    // Sets DescriptionLabel to relevent item description
                    DescriptionLabel.Text = "This adapter allows you to " + Environment.NewLine +
                                            "connect Apple Thunderbolt (USB-C) devices to" + Environment.NewLine +
                                            "external devices that use the Thunderbolt 2 standard. This includes" +
                                            Environment.NewLine +
                                            "hardrives and cameras.";

                    break;

                case "ProductSelectionRadioButton2":

                    // Sets SelectedProductPriceDecimal variable to the
                    // currently selected products price
                    productPriceDecimal = (decimal)ProductSelectionRadioButton2.Tag;

                    // Int value assigned to f in product name string
                    characterIndexInt = ProductSelectionRadioButton2.Text.IndexOf("f");

                    // Takes a sub string of product name string starting at the
                    // begining and going to the index of f
                    productNameString = ProductSelectionRadioButton2.Text.Substring(0, characterIndexInt);

                    // Sets ProductPictureBox image property to
                    // Apple_Lightening_to_VGA_Adapter
                    ProductPictureBox.Image = Properties.Resources.Apple_Lightening_to_VGA_Adapter;

                    // Sets DescriptionLabel to relevent item description
                    DescriptionLabel.Text = "This adapter allows to connect devices using the " +
                                            Environment.NewLine +
                                            "Apple Lighting Port to" +
                                            Environment.NewLine +
                                            "devices that use a VGA display port. This includes moniters " +
                                            Environment.NewLine +
                                            "and some cameras.";

                    break;

                case "ProductSelectionRadioButton3":

                    // Sets SelectedProductPriceDecimal variable to the
                    // currently selected products price
                    productPriceDecimal = (decimal)ProductSelectionRadioButton3.Tag;

                    // Int value assigned to f in product name string
                    characterIndexInt = ProductSelectionRadioButton3.Text.IndexOf("f");

                    // Takes a sub string of product name string starting at the
                    // begining and going to the index of f
                    productNameString = ProductSelectionRadioButton3.Text.Substring(0, characterIndexInt);

                    // Sets ProductPictureBox image property to
                    // Apple_USB_Cable_Adapter
                    ProductPictureBox.Image = Properties.Resources.Apple_USB_Cable_Adapter;

                    // Sets DescriptionLabel to relevent item description
                    DescriptionLabel.Text = "This device allows you to connect any " +
                                            Environment.NewLine +
                                            "device using a 32-pin Apple connector to" +
                                            Environment.NewLine +
                                            "a standard USB port. This device works with all " +
                                            Environment.NewLine +
                                            "Apple products with a 32-pin connector" +
                                            Environment.NewLine +
                                            "including iPods, iPhones, and iPads.";

                    break;

                case "ProductSelectionRadioButton4":

                    // Sets SelectedProductPriceDecimal variable to the
                    // currently selected products price
                    productPriceDecimal = (decimal)ProductSelectionRadioButton4.Tag;

                    // Int value assigned to f in product name string
                    characterIndexInt = ProductSelectionRadioButton4.Text.IndexOf("f");

                    // Takes a sub string of product name string starting at the
                    // begining and going to the index of f
                    productNameString = ProductSelectionRadioButton4.Text.Substring(0, characterIndexInt);

                    // Sets ProductPictureBox image property to
                    // Apple_USB_C_VGA_Multiport_Adapter
                    ProductPictureBox.Image = Properties.Resources.Apple_USB_C_VGA_Multiport_Adapter;

                    // Sets DescriptionLabel to relevent item description
                    DescriptionLabel.Text = "This device expands on the functionality of " +
                                            Environment.NewLine +
                                            "the USB-C port in your Apple products" +
                                            Environment.NewLine +
                                            "It adds an external moniter option, an extra USB" +
                                            Environment.NewLine +
                                            "port and passthrough charging.";

                    break;

                case "ProductSelectionRadioButton5":

                    // Sets SelectedProductPriceDecimal variable to the
                    // currently selected products price
                    productPriceDecimal = (decimal)ProductSelectionRadioButton5.Tag;

                    // Int value assigned to f in product name string
                    characterIndexInt = ProductSelectionRadioButton5.Text.IndexOf("f");

                    // Takes a sub string of product name string starting at the
                    // begining and going to the index of f
                    productNameString = ProductSelectionRadioButton5.Text.Substring(0, characterIndexInt);

                    // Sets ProductPictureBox image property to
                    // Dynex_Mini_Display_Port_to_HDMI_Adapter
                    ProductPictureBox.Image = Properties.Resources.Dynex_Mini_Display_Port_to_HDMI_Adapter;

                    // Sets DescriptionLabel to 
                    DescriptionLabel.Text = "This device converts a mini diplay port connection to a" + Environment.NewLine +
                                            " full size HDMI port connection" + Environment.NewLine +
                                            "Perfect for small form factor devices such as cameras and micro computers.";

                    break;
            }
        }

        /*
        * private void TaxRateRadioButton_CheckedChanged(object sender, EventArgs e)
        * 
        * Summary:
        *    Sets selectedRadioButtonTaxRate variable to the relevent control on the form.
        *    Sets the TaxRateGroupBox background color property to transparent after
        *    an error in ValidInput() method
        *                
        */
        private void TaxRateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Sets selectedRadioButtonTaxRate variable to the
            // clicked radio button in the tax selection group box on the form
            selectedRadioButtonTaxRate = (RadioButton)sender;

            // Sets TaxRateGroupBox back color propert to transparent
            TaxRateGroupBox.BackColor = Color.Transparent;
        }

        /*
        * private void ColorRedButton_Click(object sender, EventArgs e)
        * 
        * Summary:
        *    Event handler for ColorRedButton. Called on button click.
        *                
        */
        private void ColorRedButton_Click(object sender, EventArgs e)
        {
            // Sets DescriptionLabel fore color property to ColorRedButton fore color (Red)
            DescriptionLabel.ForeColor = ColorRedButton.ForeColor;

            // Sets DescriptionLabel back color property to ColorRedButton fore color (Red)
            DescriptionLabel.BackColor = ColorRedButton.BackColor;
        }

        /*
        * private void ColorGreenButton_Click(object sender, EventArgs e)
        * 
        * Summary:
        *    Event handler for ColorGreenButton. Called on button click.
        *                
        */
        private void ColorGreenButton_Click(object sender, EventArgs e)
        {
            // Sets DescriptionLabel fore color property to ColorGreenButton fore color (Green)
            DescriptionLabel.ForeColor = ColorGreenButton.ForeColor;

            // Sets DescriptionLabel back color property to ColorGreenButton back color (Green)
            DescriptionLabel.BackColor = ColorGreenButton.BackColor;
        }

        /*
        * private void ColorPurpleButton_Click(object sender, EventArgs e)
        * 
        * Summary:
        *    Event handler for ColorPurpleButton. Called on button click.
        *                
        */
        private void ColorPurpleButton_Click(object sender, EventArgs e)
        {
            // Sets DescriptionLabel fore color property to ColorPurpleButton fore color (Purple)
            DescriptionLabel.ForeColor = ColorPurpleButton.ForeColor;

            // Sets DescriptionLabel back color property to ColorPurpleButton back color (Purple)
            DescriptionLabel.BackColor = ColorPurpleButton.BackColor;
        }

        /*
        * private void ColorBlueButton_Click(object sender, EventArgs e)
        * 
        * Summary:
        *    Event handler for ColorBlueButton. Called on button click.
        *                
        */
        private void ColorBlueButton_Click(object sender, EventArgs e)
        {
            // Sets DescriptionLabel fore color property to ColorBlueButton fore color (Blue)
            DescriptionLabel.ForeColor = ColorBlueButton.ForeColor;

            // Sets DescriptionLabel back color property to ColorBlueButton back color (Blue)
            DescriptionLabel.BackColor = ColorBlueButton.BackColor;
        }

        /*
        * private void TestButton_Click(object sender, EventArgs e)
        * 
        * Summary:
        *     Test button to test form functionality. Called on test button click
        *     
        */
        private void TestButton_Click(object sender, EventArgs e)
        {
            // Sets Customer Name to - Bob Ross - on the form
            CustomerNameTextBox.Text = "Bob Ross";

            // Sets Customer Address to - 1234 Main Street - on the form
            CustomerAddressTextBox.Text = "1234 Main Street";

            // Sets Customer City to - Kalamazoo - on the form
            CustomerCityTextBox.Text = "Kalamazoo";

            // Sets Customer State to - MI - on the form
            CustomerStateTextBox.Text = "MI";

            // Sets Customer Zipcode to - 49009 - on the form
            CustomerZipMaskedTextBox.Text = "49009";

            // Sets Customer Phone Number to - 123-1234 - on the form
            CustomerPhoneNumberMaskedTextBox.Text = "123-1234";

            // Sets Quanity to - 1 - on the form
            QuantityTextBox.Text = "10";

            // Sets Product Selected to - Apple Thunderbolt (USB-C) To Thunderbolt 2 Adapter - on the form
            ProductSelectionRadioButton1.Checked = true;

            // Sets Tax Rate to - Business - on the form
            TaxRateRadioButton1.Checked = true;

            // Sets Packaging option to - Box - on the form 
            PackagingOptionsCheckBox1.Checked = true;

            // Sets Packaging option to - Padding - on the form 
            PackagingOptionsCheckBox2.Checked = true;

            // Sets Packaging option to - Delivery - on the form 
            PackagingOptionsCheckBox3.Checked = true;

            // Sets Packaging option to - Wrapping - on the form 
            PackagingOptionsCheckBox4.Checked = true;
        }

        /*
        * private void ExitButton_Click(object sender, EventArgs e)
        * 
        * Summary:
        *    Closes the applications's active form. Called on exit button click
        *                
        */
        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Closes the active form
            this.Close();
        }
    }
}