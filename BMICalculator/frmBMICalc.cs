using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalcualtor
{
    public partial class frmBMICalc : Form
    {
        bool useImperial = true;

        public frmBMICalc()
        {
            InitializeComponent();
            
        }

        private void rbMetric_CheckedChanged(object sender, EventArgs e)
        {
            //Reinitialize to ensure that Metric calculations are being used
            setEvalType();
        }

        private void rbImperial_CheckedChanged(object sender, EventArgs e)
        {
            //Reinitialize to ensure that Imperial calculations are being used
            setEvalType();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            //Take values from the text boxes on the form
            string strMajorUnitVal = txtMajorUnit.Text;
            string strMinorUnitVal = txtMinorUnit.Text;
            string strWeight = txtWeight.Text;
            bool validInput = true;
            double dHeightMajorUnitVal;
            double dHeightMinorUnitVal;
            double dWeight;

            if (strMajorUnitVal == "")
            {
                strMajorUnitVal = "0";
            }

            if (strMinorUnitVal == "")
            {
                strMinorUnitVal = "0";
            }

            if (strWeight == "")
            {
                strWeight = "0";
            }

            //Use TryParse to test that values entered can be parsed to double data type
            if (double.TryParse(strMajorUnitVal, out dHeightMajorUnitVal) == false)
            {
                validInput = false;
            }

            if (double.TryParse(strMinorUnitVal, out dHeightMinorUnitVal) == false)
            {
                validInput = false;
            }

            if (double.TryParse(strWeight, out dWeight) == false)
            {
                validInput = false;
            }

            if (!validInput)
            {
                MessageBox.Show("An invalid value was entered for one or more fields. Please try again.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }



            //Instantiate the BMI Object
            BMI calc = new BMI();

            //set the properties of the new object
            calc.HeightMajorUnits = dHeightMajorUnitVal;
            calc.HeightMinorUnits = dHeightMinorUnitVal;
            calc.Weight = dWeight;
            calc.UseImperial = useImperial;

            //Cal the proper class method based on the measurement type
            if (useImperial)
            {
                calc.calcBMI_Imperial();
            }
            else
            {
                calc.calcBMI_Metric();
            }

            //Show the results of the calculation in a label below the form controls
            lblResults.Text = calc.ToString(calc.BodyMassIndex.ToString("F2"));
             

        }

        private void setEvalType()
        {
            //update the flag for measurement type accordingly and change measurement label names
            //Also clear values from text boxes to ensure that data is re-entered for the new measurement type
            if (rbMetric.Checked)
            {
                useImperial = false;
                lblMajorUnit.Text = "Meters";
                lblMinorUnit.Text = "Centimeters";
                lblWeightUnit.Text = "Kilograms";
                txtMajorUnit.Text = "";
                txtMinorUnit.Text = "";
                txtWeight.Text = "";

            }
            else
            {
                //update the flag for measurement type accordingly and change measurement label names
                //Also clear values from text boxes to ensure that data is re-entered for the new measurement type
                useImperial = true;
                lblMajorUnit.Text = "Feet";
                lblMinorUnit.Text = "Inches";
                lblWeightUnit.Text = "Pounds";
                txtMajorUnit.Text = "";
                txtMinorUnit.Text = "";
                txtWeight.Text = "";
            }
        }



    }
}
