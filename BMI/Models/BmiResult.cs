namespace Bmi.Models
{
    public class BmiResult
    {
        public double Bmi { get; set; }
        public string Category { get; set; }

        public BmiResult()
        {

        }
            
        public BmiResult(double bmi, string category)
        {
            this.Bmi = bmi;
            this.Category = category;
        }
    }
}