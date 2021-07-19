namespace MyWeeklyTask1
{
    public class CalcHistory
    {
        public CalcHistory(double firstNum, double secondNum, char calOperation, double result) 
        {
            this.firstNum = firstNum;
                this.secondNum = secondNum;
                this.calOperation = calOperation;
                this.result = result;

                this.calculation = convert.ToString(firstNum + " " + calOperation + " " + secondNum + "=" + result) ;
               
        }
        
        public double firstNum { get; set; }
        public double secondNum { get; set; }
        public char calOperation { get; set; }
        public double result { get; set; }
        public string calculation { get; set; }

    }
}