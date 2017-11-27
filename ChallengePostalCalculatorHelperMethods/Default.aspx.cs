using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculatorHelperMethods
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void elementChanged(object sender, EventArgs e)
        {
            //check to see if the input is valid, if so, parse values and calculate price
            if (formValidator())
            {
                double width;
                double height;
                double length;
                double mult;
                parseValues(out width, out height, out length, out mult);
                calculatePrice(width, height, length, mult);
            }
            else
                //if the form is not valid, clear the price label
                priceLabel.Text = "";
        }


        //ensure form has enough info
        private bool formValidator()
        {
            double width;
            double height;
            if(
                double.TryParse(widthBox.Text.Trim(), out width) &&
                double.TryParse(heightBox.Text.Trim(), out height) &&
                    (groundButton.Checked ||
                    airButton.Checked ||
                    nextDayButton.Checked))
                return true;

            return false;
        }


        //parse values from input boxes and radio buttons
        private void parseValues(out double height, out double width, out double length, out double shippingMultiplier)
        {

            double.TryParse(widthBox.Text.Trim(), out width);
            double.TryParse(heightBox.Text.Trim(), out height);
            if (!double.TryParse(lengthBox.Text.Trim(), out length))
                length = 1;
            shippingMultiplier =
                (groundButton.Checked) ? .15 :
                (airButton.Checked) ? .25 : .45;

        }

        //calculate the price and print to priceLabel via printPrice()
        private void calculatePrice(double width, double height, double length, double mult)
        {
            priceLabel.Text = printPrice(width * height * length * mult);
        }

        //format string with price
        private string printPrice(double price)
        {
            string priceString = string.Format("It will cost {0:C} to ship this package.", price);
            return priceString;
        }
    }
}