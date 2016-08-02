using System;

namespace EventTypeModel
{
    public class clsEventTypeModel :  IEventTypeModel
    {
        private int firstNumber;
        private int secondNumber;
        private int multiNumber;

        private string firstString;
        private string secondString;
        private string multiString;
        private string dashBoardString;

        public event EventHandler displayHandler;
        public clsEventTypeModel()
        {
        }

        public clsEventTypeModel(int firstNumber, int secondNumber, string firstString, string secondString)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.firstString = firstString;
            this.secondString = secondString;
            this.multiNumber = firstNumber * secondNumber;
            this.multiString = firstString + " " + secondString;
        }

        public void OnDisplayHandler(myEventArgs e)
        {
            if (displayHandler != null)
            {
                displayHandler(this, e );
            }
        }

        public int FirstNumber { get {return firstNumber;  }}
        public int SecondNumber { get { return secondNumber; } }
        int MultiNumber { get { return multiNumber; } }
        public string Name { get { return firstString; } }
        public string FirstString { get { return firstString; } }
        public string SecondString {  get { return secondString; } }
        public string DashBoardString { get { return dashBoardString; } }
        string MultiString { get { return multiString; } }

        public string getPrintString(int tokenNumber)
        {
            string displayString = tokenNumber.ToString();

            try
            {
                if ((tokenNumber % multiNumber) == 0)
                {
                    displayString = multiString;
                }
                else if ((tokenNumber % firstNumber) == 0)
                {
                    displayString = firstString;
                }
                else if ((tokenNumber % secondNumber) == 0)
                {
                    displayString = secondString;
                }
            }
            catch (DivideByZeroException ex)
            {
                displayString = "DividbyZeroError";
            }
            catch (Exception ex)
            {
                displayString = ex.Message;
            }
            return displayString;
        } 

        public void setDashBoard()
        {
            string displayString = "   Event Type : " + this.Name;
            displayString += (Environment.NewLine + "   ========================================");
            for (int i = 1; i < 101; i++)
            {
                string getEventString = getPrintString(i);
                displayString += String.Format("{0}   {1}      Hello   :   {2}", Environment.NewLine, i.ToString().PadLeft(3, '0'), getEventString);
            }
            dashBoardString = displayString;
            //return displayString;
        } 
    }
}
