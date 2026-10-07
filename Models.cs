using Microsoft.ML.Data;

namespace MachinelearningClass.Cohort
{
    public class InsuranceData
    {
        [LoadColumn(0)]
        public float Age { get; set; }

        [LoadColumn(2)]
        public float HighBp { get; set; }

        [LoadColumn(3)]
        public float LowBp { get; set; }

        [LoadColumn(1)]
        public float Premium { get; set; }
    }
}