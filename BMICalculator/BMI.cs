using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalcualtor
{
    internal class BMI
    {
        //private members of the BMI class
        private double heightMajorUnits;
        private double heightMinorUnits;
        private double weight;
        private bool useImperial;
        private double bodyMassIndex;
        private string weightStatus;

        //Property for Height Major Units Value
        public double HeightMajorUnits
        {
            get
            {
                return heightMajorUnits;    
            }
            set
            {
                heightMajorUnits = value;
            }
        }

        //Property for Height Minor Units Value
        public double HeightMinorUnits
        {
            get
            {
                return heightMinorUnits;
            }
            set
            {
                heightMinorUnits = value;
            }
        }

        //Property for Weight
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        //Property for the Imperial vs. Non-Imperial flag
        public bool UseImperial
        {
            get
            {
                return useImperial;
            }
            set
            {
                useImperial = value;
            }
        }

        //Property for the Body Mass Index
        public double BodyMassIndex
        {
            get
            {
                return bodyMassIndex;
            }
            set
            {
                bodyMassIndex = value;
            }
        }

        //Property for the Weight Status
        public string WeightStatus
        {
            get
            {
                return weightStatus;
            }
            set
            {
                weightStatus = value;
            }
        }

        public double calcBMI_Imperial()
        {
            /*
            Imperial Calculation - weight in pounds divided by height in inches, squared, multipled by conversion factor of 703
            
            **Pseudocode
            Input feet and inches for height
            Input pounds for weight
            heightValue = convert feet and inches to inches
            heightValue = heightValue * heightValue
            BMI = weight(lbs) / heightValue * 703
            */

            double heightInInches = (HeightMajorUnits * 12) + HeightMinorUnits;
            double bmi = (Weight / (heightInInches * heightInInches) * 703);
            
            //update BodyMassIndex Property
            BodyMassIndex = bmi;
            
            //Call the method to categorize weight status
            calcWeightStatus(bmi);

            //return the value of the BMI calculation
            return BodyMassIndex;

        }

        public double calcBMI_Metric()
        {
            /*
            Metric Calculation - weight in kilograms divided by height in meters squared

            **Pseudocode
            Input meters and centimeters for height
            Input kilograms for weight
            heightValue = convert meters and centimeters to meters
            heightValue = heightValue * heightValue
            BMI = weight(kg) / heightValue
            */

            double heightInMeters = (HeightMajorUnits + (HeightMinorUnits * .01));
            double bmi = (Weight / (heightInMeters * heightInMeters));

            //update BodyMassIndex Property
            BodyMassIndex = bmi;

            //Call the method to categorize weight status
            calcWeightStatus(bmi);

            //return the value of the BMI calculation
            return BodyMassIndex;

        }



        public string calcWeightStatus(double calculatedBMI)
        {
            
            /*Use a nested if based on the values in the table in the 
            **text book for calculating 'Weight Status'
            */
            if (calculatedBMI < 18.5)
            {
                weightStatus = "Underweight";
            }
            else if (calculatedBMI < 25)
            {
                weightStatus = "Normal";
            }
            else if (calculatedBMI < 30)
            {
                weightStatus = "Overweight";
            }
            else
            {
                weightStatus = "Obese";
            }

            WeightStatus = weightStatus;
            
            //return the weightStatus value
            return WeightStatus;
        }

        //Use the ToString method to generate the result string for display
        public string ToString(string bmi)
        {
            if (bmi != "NaN")
            { 
            return "Your BMI has been calculated to be " + bmi + ", which is considered to be " + WeightStatus + " based on the current cateogorization outlined by the U.S. Department of Heatlh and Human Services";
            }
            else
            {
            return "Your BMI could not be calculated. Please ensure that you have entered all information accurately and try again.";
            }
        }
    }
}
