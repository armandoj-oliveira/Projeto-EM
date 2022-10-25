class Calculator : IOperations // os métodos da interface são herdados pela classe
{


    List<double> listNumbers = new List<double>();

    public double Result;
    public double FirstNum;
    public double SecondNum;

    public Calculator() { }

    public Calculator(double result, double firstNum, double secondNum) {
        Result = result;
        FirstNum = firstNum;
        SecondNum = secondNum;
    }

    public void Addition(double firstNum, double secondNum) => Result = firstNum + secondNum;

    public void Subtraction(double firstNum, double secondNum) => Result = firstNum + secondNum;

    public void Multiplication(double firstNum, double secondNum) => Result = firstNum * secondNum;

    public void Division(double firstNum, double secondNum) => Result = firstNum / secondNum;

}