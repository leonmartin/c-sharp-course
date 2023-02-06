using System.Collections.Generic;

class Calculator
{
    public List<double> PreviousResults;
    public Calculator()
    {
        PreviousResults = new List<double>();
    }

    public double Add(double numberOne, double numberTwo)
    {
        double sum = numberOne + numberTwo;

        PreviousResults.Add(sum);

        return sum;
    }

    public double Subtract(double numberOne, double numberTwo)
    {
        double difference = numberOne - numberTwo;

        PreviousResults.Add(difference);

        return difference;
    }

}