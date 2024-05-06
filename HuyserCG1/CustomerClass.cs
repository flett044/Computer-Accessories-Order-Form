// Class CustomerClass
// An instantiation of this class represents a customer.
// Class methods calulates line total, customer totals, management totals, taxes, discounts and packaging totals.
// 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HuyserCG1
{
    internal class CustomerClass
    {
        // ITEM PRICE CONSTANTS

        // Apple Thunderbolt (USB-C) To Thunderbolt 2 Adapter
        private const decimal _PRODUCT1_PRICE_DECIMAL = 50.00m;

        // Apple Lighting to VGA Adapter
        private const decimal _PRODUCT2_PRICE_DECIMAL = 39.99m;

        // Apple USB Cable Adapter
        private const decimal _PRODUCT3_PRICE_DECIMAL = 25.00m;

        // Apple USB-C VGA Multiport Adapter
        private const decimal _PRODUCT4_PRICE_DECIMAL = 90.00m;

        // Dynex Mini Display port to HDMI Adapter
        private const decimal _PRODUCT5_PRICE_DECIMAL = 50.55m;

        // DISCOUNT CONSTANTS
        // Discount applied for 5 items or less
        private const decimal _DISCOUNT_1 = .10m;

        // Discount applied for 5 items or more
        private const decimal _DISCOUNT_2 = .30m;

        // TAX RATE CONSTANTS
        private const decimal _TAXRATE_1_DECIMAL = .05m;
        private const decimal _TAXRATE_2_DECIMAL = .10m;
        private const decimal _TAXRATE_3_DECIMAL = .15m;

        // PACKAGING ITEM CONSTANTS
        private const decimal _PACKAGING_OPTION_1_PRICE_DECIMAL = 5.00m;
        private const decimal _PACKAGING_OPTION_2_PRICE_DECIMAL = 8.00m;
        private const decimal _PACKAGING_OPTION_3_PRICE_DECIMAL = 25.00m;
        private const decimal _PACKAGING_OPTION_4_PRICE_DECIMAL = 10.00m;

        // ACCUMULATORS & TOTALS:

        // Total amount due per line
        private static decimal _totalDecimal = 0.0m;

        // Total items purchased
        private static int _totalItemsInt = 0;

        // Price of product selected by customer
        private decimal _productPriceDecimal = 0.0m;

        // Total amount due before any other fees are added or discounts applied
        private static decimal _totalAmountDueDecimal = 0.0m;

        // Calculated amount of tax due
        private static decimal _calculatedTaxAmountDecimal = 0.0m;

        // Calculated amount of discount to be subtracted from total
        private static decimal _calculatedDiscountAmountDecimal = 0.0m;

        // Total amount due for packaging costs
        private static decimal _totalPackagingAmountDueDecimal = 0.0m;

        // Tax rate selected by customer
        private static decimal _taxRateDecimal = 0.0m;

        // Holds the current tax type
        private static string _taxTypeString = "";

        // Product quuantity entered by customer
        private int _quantityInt = 0;

        // Total amount due pre discount
        private static decimal _totalAmountDuePreDiscountDecimal = 0.0m;

        // Total amount due after taxes, discounts, and fees are applied
        private static decimal _finalTotalDecimal = 0.0m;

        // Accumulation of total customers
        private static int _accumMgmtTotalCustomersInt = 0;

        // Accumulation of total discounts applied
        private static int _accumMgmtTotalCustomerDiscountsInt = 0;

        // Accumulation of total amount collected
        private static decimal _accumMgmtTotalDecimal = 0.0m;

        // WORKING VARIABLES

        // Holds the discount selected
        private static string _discountString = "";

        // Holds the packaging options text as a string selected
        private static string _packagingOptionString = "";

        // Holds the selected dicount checkbox control as an object on the form
        private static CheckBox _selectedDiscountCheckBox = new();

        // Holds the selected taxrate radiobutton control as an object on the form
        private static RadioButton _selectedTaxrateRadioButton = new();

        // An array used to hold the packaging options selected on the form
        private static new CheckBox[] _packagingOptionsCheckBoxArray;  

        // CONSTRUCTORS

        // Empty constructor for form load
        public CustomerClass() { }

        // Intitial contructor called for each customer
        public CustomerClass(int pQuantityInt, 
                         decimal pProductPriceDecimal, 
                         CheckBox pDiscountCheckBox, 
                         RadioButton pTaxrateRadioButton,
                         CheckBox[] pPackagingCheckBoxArray)
        {
            // The following assigns incoming parameters to there relevent backing fields ****
            // Quanity of items purchased
            _quantityInt = pQuantityInt;

            // The price stored in the tag property of the product radio button selected
            _productPriceDecimal = pProductPriceDecimal;    

            // The discount checkbox
            _selectedDiscountCheckBox = pDiscountCheckBox;

            // The taxrate stored in the tag property of the taxrate radio button selected
            _selectedTaxrateRadioButton = pTaxrateRadioButton;

            // An array containing the packaging options selected on the form
            _packagingOptionsCheckBoxArray = pPackagingCheckBoxArray;

            //******************************************************************************

            // Calls the calculate line item method at object creation
            CalculateLineItems(_quantityInt, _productPriceDecimal);
        }

        // Second constructor called when clearing management or customer totals. Called on click of new customer or
        // clear management totals button, or end order button 
        public CustomerClass(string flag)
        {
            // Tests the flag parameter coming in from constructor
            switch (flag)
            {
                // If case matches flag matches ClearMGMT string
                case "ClearMGMT":

                    ClearMgmtTotals();

                    break;

                // If case matches flag ClearCUST string
                case "ClearCUST":

                    ClearCustTotals();

                    break;

                // If case matches flag EndORDER string
                case "EndORDER":
                    // Calls calculate discount method
                    CalculateDiscount(_quantityInt, _selectedDiscountCheckBox);

                    // Gets taxamount from form
                    GetTaxAmount(_selectedTaxrateRadioButton);

                    // Calculates the tax rate
                    CalculateTaxRate();

                    // Calculates packaging fees due
                    CalculatePackageFees(_packagingOptionsCheckBoxArray);

                    // Accumulates cust totals
                    CustomerAccumulation();

                    // Accumulates management totals
                    ManagementAccumulation(_selectedDiscountCheckBox);

                    break;
            }
        }

        // PROPERTIES

        // The below properties contain the pricing for the products on the form ********
        public decimal Product1Price { get { return _PRODUCT1_PRICE_DECIMAL; } }

        public decimal Product2Price { get { return _PRODUCT2_PRICE_DECIMAL; } }

        public decimal Product3Price { get { return _PRODUCT3_PRICE_DECIMAL; } }

        public decimal Product4Price { get { return _PRODUCT4_PRICE_DECIMAL; } }

        public decimal Product5Price { get { return _PRODUCT5_PRICE_DECIMAL; } }

        // ********************************************************************************

        // The below properties contain the discount selected on the form *****************
        public decimal Discount1 { get { return _DISCOUNT_1; } }

        public decimal Discount2 { get { return _DISCOUNT_2; } }

        // ********************************************************************************
      
        // The below properties contain the taxrate selected on the form ******************
        public decimal Taxrate1 { get { return _TAXRATE_1_DECIMAL; } }

        public decimal Taxrate2 { get { return _TAXRATE_2_DECIMAL; } }

        public decimal Taxrate3 { get { return _TAXRATE_3_DECIMAL; } }

        // ********************************************************************************

        // The below property contains the packaging options selected on the form *********
        public decimal PackagingOption1 { get { return _PACKAGING_OPTION_1_PRICE_DECIMAL; } }

        public decimal PackagingOption2 { get { return _PACKAGING_OPTION_2_PRICE_DECIMAL; } }

        public decimal PackagingOption3 { get { return _PACKAGING_OPTION_3_PRICE_DECIMAL; } }

        public decimal PackagingOption4 { get { return _PACKAGING_OPTION_4_PRICE_DECIMAL; } }

        // *********************************************************************************

        // Property contains the total amount due pre discount
        public decimal TotalAmountDuePreDiscount { get { return _totalAmountDuePreDiscountDecimal; } }

        // Property contains the line total 
        public decimal Total { get { return _totalDecimal; } }

        // Property contains the final total before any calculations are applied
        public decimal  FinalTotal { get { return _finalTotalDecimal; } }

        // Property contains the tax amount due 
        public decimal TaxAmountDue { get { return _calculatedTaxAmountDecimal; } }

        // Propery contains the tax rate based on selection on form
        public decimal TaxRate { get { return _taxRateDecimal; } }
        
        // Property contains the price of the item selected
        public decimal Price { get { return _productPriceDecimal; } }

        // Property contains the quanity of the item selected
        public decimal Quantity { get { return _quantityInt; } }

        // Property contains the total customers over all orders
        public int MgmtTotalCustomer { get { return _accumMgmtTotalCustomersInt; } }

        // Property contains the total items for one customer
        public int TotalItems { get { return _totalItemsInt; } }

        // Property contains the total packaging amount due 
        public decimal PackagingAmountDue { get { return _totalPackagingAmountDueDecimal; } }

        // Property contains the total number of discounts used
        public decimal MgmtTotalDiscounts { get { return _accumMgmtTotalCustomerDiscountsInt; } }

        // Property contains the final total after discount, tax etc
        public decimal TotalAmountDue { get { return _totalAmountDueDecimal; } }

        // Property contains the string from the taxrate radio buttons for later display on form
        public string TaxType { get { return _taxTypeString; } }

        // Property contains the total for all customers
        public decimal MgmtTotal { get { return _accumMgmtTotalDecimal; } }

        // Property contains the string of the discount applied to the order
        public string Discount { get { return _discountString; } }

        // Property contains the string of any packaging options selected on the form
        public string Packaging { get { return _packagingOptionString; } }

        // METHODS

        /*
        * private void CalculateLineItems()
        * 
        * Summary:
        *   Calculates the total for the line on the form. Adds line 
        *   totals to final totals for later calcs.
        * Inputs:
        *   Quantity of items
        *   Price of selected item on form
        * Outputs:
        *   None - void 
        * Return:
        *   None
        *   
        */
        private void CalculateLineItems(int quantityInt, decimal productPriceDecimal)
        {
            // Calculates the total price for the line
            _totalDecimal = quantityInt * productPriceDecimal;

            // Adds current quantity to total quantity
            _totalItemsInt += quantityInt;

            // Adds each line total to total amount due 
            _totalAmountDueDecimal += _totalDecimal;
        }

        /*
        * private void CalculateTaxAmount()
        * 
        * Summary:
        *   Calculates the tax amount that will be added to the final total on the form.
        * Inputs:
        *   None
        * Outputs:
        *   None - void 
        * Return:
        *   None
        *   
        */
        private void GetTaxAmount(RadioButton taxRateRadioButton)
        {
            // Switch determines which taxrate radio button is
            // selected by comparing radiobutton name to each case
            switch (taxRateRadioButton.Name)
            {
                // Sets currentTaxRateDecimal to business taxrate
                // from TaxRateRadioButton1 tag property
                case "TaxRateRadioButton1":

                    // Sets taxrate decimal to radio button tag
                    _taxRateDecimal = (decimal) taxRateRadioButton.Tag;

                    // Sets to taxrate button text for later output on form
                    _taxTypeString = taxRateRadioButton.Text;

                    break;

                // Sets currentTaxRateDecimal to personal taxrate from
                // TaxRateRadioButton2 tag property
                case "TaxRateRadioButton2":

                    // Sets taxrate decimal to radio button tag
                    _taxRateDecimal = (decimal)taxRateRadioButton.Tag; ;

                    // Sets to taxrate button text for later outputnon form
                    _taxTypeString = taxRateRadioButton.Text;

                    break;

                // Sets currentTaxRateDecimal to for resale taxrate from
                // TaxRateRadioButton3 tag property
                case "TaxRateRadioButton3":

                    // Sets taxrate decimal to radio button tag
                    _taxRateDecimal = (decimal)taxRateRadioButton.Tag;

                    // Sets to taxrate button text for later outputnon form
                    _taxTypeString = taxRateRadioButton.Text;

                    break;
            }
        }

        /*
        * private void CalculateTaxRate()
        * 
        * Summary:
        *   Calculates the tax rate
        * Inputs:
        *   None
        * Outputs:
        *   None - void 
        * Return:
        *   None
        *   
        */
        private void CalculateTaxRate()
        {
            // Calculates the total tax amount due when
            // TaxRateRadioButton1 is selected
            _calculatedTaxAmountDecimal = _totalAmountDueDecimal * _taxRateDecimal;
        }

        /*
        * private void CalculateDiscount()
        * 
        * Summary:
        *   Calculates the discount that will be applied to the final total if discount checkbox is checked. 
        *   If not checked sets the discountString to empty so it doesnt show up on the form.
        * Inputs:
        *   None
        * Outputs:
        *   None - void 
        * Return:
        *   None
        *   
        */
        private void CalculateDiscount(int quantityInt, CheckBox DiscountCheckBox)
        {
            // If statements test if discount checkbox is selected. If true
            // moves to next if statement. If false sets discount string to
            // an empty string so it does show on the form.
            if (DiscountCheckBox.Checked)
            {
                // Holds the total before discount for later output on form
                _totalAmountDuePreDiscountDecimal = _totalAmountDueDecimal;

                // If statement test if quantity entered by customer is less than or equal to 5.
                // If less than or equal to five a discount is appled to the final total.
                // If more than 5 a different discount is applied to the total
                if (quantityInt <= 5)
                {
                    // Calculates discount amount based off item quantity
                    _calculatedDiscountAmountDecimal = _totalAmountDueDecimal * _DISCOUNT_1;

                    // Calculates total with discount applied
                    _totalAmountDueDecimal -= _calculatedDiscountAmountDecimal;

                    // Sets discount string for final output on form
                    _discountString = "Disount Amount is:".PadRight(20) + _calculatedDiscountAmountDecimal.ToString("c").PadLeft(20) + Environment.NewLine +
                                     "Amnt Due After discount is:".PadRight(20) + _totalAmountDueDecimal.ToString("c").PadLeft(13) + Environment.NewLine;
                }
                else
                {
                    // Calculates discount amount based off item quantity
                    _calculatedDiscountAmountDecimal = _totalAmountDueDecimal * _DISCOUNT_2;

                    // Calculates total with discount applied
                    _totalAmountDueDecimal -= _calculatedDiscountAmountDecimal;

                    // Sets discount string for final output on form
                    _discountString = "Disount Amount is".PadRight(20) + _calculatedDiscountAmountDecimal.ToString("c").PadLeft(20) + Environment.NewLine +
                                     "Amnt Due After discount is:".PadRight(20) + _totalAmountDueDecimal.ToString("c").PadLeft(13) + Environment.NewLine;
                }
            }
            else
            {
                // Sets discount string to empty if discount check box not checked. Prevent discount total from showing on form
                _discountString = "";
            }
        }

        /*
        * private void CalculatePackageFees()
        * 
        * Summary:
        *   Calculates the packaging fee that will be added to the final total 
        *   based upon user selection on the form.
        * Inputs:
        *   None
        * Outputs:
        *   None - void 
        * Return:
        *   None
        *   
        */
        private void CalculatePackageFees(CheckBox[] packagingOptionsCheckBoxArray)
        {
            // Loop checks each packaging option in the packaging array for a check then acumulates
            // the packaging charge for each checked box to a running total
            foreach (CheckBox checkbox in packagingOptionsCheckBoxArray)
            {
                if (checkbox.Checked)
                {
                    _totalPackagingAmountDueDecimal += (decimal) checkbox.Tag;

                    // Assigns the checkbox text string to a packaging option string for later
                    // display on form
                    _packagingOptionString += checkbox.Text + Environment.NewLine;
                }
            }
        }


        /*
        * private void CustomerAccumulation()
        * 
        * Summary:
        *   Accumulates each line total to final total, each line qty to total qty, 
        *   all fees/taxes to final total, final total to running accumulation of all customer totals, 
        *   and total qty to running acumulation of all qty of items purchased.
        * Inputs:
        *   None
        * Outputs:
        *   None - void 
        * Return:
        *   None
        *   
        */
        private void CustomerAccumulation()
        {
            // Accumulates total amount die to the final total
            _finalTotalDecimal += _totalAmountDueDecimal;

            // Adds tax amount due to final total
            _finalTotalDecimal += _calculatedTaxAmountDecimal;

            // Adds packaging amount due to final total
            _finalTotalDecimal += _totalPackagingAmountDueDecimal;
        }

        /*
        * private void ManagementAccumulation()
        * 
        * Summary:
        *   Calculates Mgmt totals
        * Inputs:
        *   None
        * Outputs:
        *   None - void 
        * Return:
        *   None
        *   
        */
        private void ManagementAccumulation(CheckBox checkbox)
        {
            // Accumulates total amount of $ money between all customers
            _accumMgmtTotalDecimal += _finalTotalDecimal;

            // Counts amount of customers that have a discount applied
            if (checkbox.Checked)
            {
                _accumMgmtTotalCustomerDiscountsInt++;
            }

            // Counts up 1 every time new customer is clicked. Counts
            // as one customer every click
            _accumMgmtTotalCustomersInt++;
        }

        /*
        * private void ClearMgmtTotals()
        * 
        * Summary:
        *   Clears the variables associated with accumulating management totals
        * Inputs:
        *   None
        * Outputs:
        *   None - void 
        * Return:
        *   None
        *   
        */
        private void ClearMgmtTotals()
        {
            // Zero total customers for all orders
            _accumMgmtTotalCustomersInt = 0;

            // Zeros total customers with a discount for all orders
            _accumMgmtTotalCustomerDiscountsInt = 0;

            // Zeros Mgmt total
            _accumMgmtTotalDecimal = 0.0m;
        }

        /*
       * private void ClearCustTotals()
       * 
       * Summary:
       *   Clears the variables associated with accumulating customer totals
       * Inputs:
       *   None
       * Outputs:
       *   None - void 
       * Return:
       *   None
       *   
       */
        private void ClearCustTotals()
        {
            // Zeros total for new customer calculations
            _totalDecimal = 0;

            // Zeros total items for new customer calculations
            _totalItemsInt = 0;

            // Zeros final total for new customer calculations
            _finalTotalDecimal = 0;

            // Zeros total amount due for new customer calculations
            _totalAmountDueDecimal = 0;

            // Zeros packaging amount due for new customer calculations
            _totalPackagingAmountDueDecimal = 0;

            // Resets the packaging options string to emptyy
            _packagingOptionString = "";
        }
    }
}
