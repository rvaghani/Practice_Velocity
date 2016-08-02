using System;

namespace EventTypeModel
{
    public interface IEventTypeModel
    {
        int FirstNumber { get; }
        int SecondNumber { get; }
        string Name { get; }
        string FirstString {  get; }
        string SecondString {  get; }
        string DashBoardString { get; }
        string getPrintString(int tokenNumber);
        void setDashBoard();
        void OnDisplayHandler(myEventArgs e);
    }
}
