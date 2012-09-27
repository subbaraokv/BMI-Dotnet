# Bmi - Dotnet #

**Bmi - Dotnet** is a Bmi calculator library for .Net. 

## How to use ##
To use Bmi- dotnet you can follow the syntax below.

>  double weightInImperialMode = 190;
>  double heightInImperialMode = 72;
> var calculator = new BmiCalculator();
> calculator.CalculateWeight(weightInImperialMode, heightInImperialMode));

> double weightInMetricMode = 85;
> double heightInMetriMode = 1.82;

> var metricCalculator = new BmiCalculator(FormulaType.Metric);
> metricCalculator.CalculateWeight(weightInMetricMode, heightInMetriMode));

> BmiResult bmiResult = calculator.CalculateResult(weightInImperialMode, heightInImperialMode);


## How to get it? ##

Download a **nuget** package at [nuget.org](https://nuget.org/packages/Bmi-Dotnet/) .
