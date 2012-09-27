namespace Bmi.Models
{
    public class BmiResult
    {
        public double Bmi { get; set; }
        public string Category { get; set; }

        public BmiResult()
        {

        }
            
        public BmiResult(double weight, string category)
        {
            this.Bmi = weight;
            this.Category = category;
        }
    }
}