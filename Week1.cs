using MachinelearningClass.Cohort;
using MachinelearningClass.Regression;
using Microsoft.ML;
//using Microsoft.ML.AutoML;
using static MachinelearningClass.Regression.DataRegression;

namespace MachinelearningClass
{
    public static class Week1
    {
        public static void Lab1_SimplestMLCodeSinglePrediction()
        {
            var mlcontext = new MLContext();
            var data = mlcontext.Data.LoadFromEnumerable(DataRegression.GetLinearInsuranceData());
            

            var pipeline = mlcontext.Transforms.Concatenate("Features", "Age")
            .Append(mlcontext.Regression.Trainers.Ols(labelColumnName:"Premium",
            featureColumnName: "Features"));

            var model = pipeline.Fit(data);
            var pe = mlcontext.Model.
                        CreatePredictionEngine<InsuranceData, InsurancePrediction>(model);

            var prediction = pe.Predict(new InsuranceData {Age = 82});

            Console.WriteLine(prediction.PredictedPremium1);
            Console.Read();             
                        
        }
    }
}