using System.Globalization;
using System;

public class Calculator
{

    List<Details> _statement = new List<Details>();

    public Calculator()
    {
        var file = File.ReadAllLines("C:\\Users\\EDSTEM\\source\\repos\\ConsoleProgramming\\Assignment_Balance\\test.csv");
        List<string> logList = new List<string>(file);
        foreach (string item in logList)
        {
            string[] list = item.Split(",");
            _statement.Add(new Details(list[0], double.Parse(list[1]), list[2]));
        }

    }
    public double Balance()
    {
        double totalBalance = 0;
        foreach (var item in _statement)
        {
            totalBalance += item.expense;
        }
        return totalBalance;
    }
    public void MonthBalance()
    {
        double totalNetBalance = 0.0;
        Console.WriteLine("enter the month-name to get statement");
        string month = Console.ReadLine();
        foreach (var item in _statement)
        {
            // convert string to date
            DateTime date = DateTime.ParseExact(item.date, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            if (date.Month == DateTime.ParseExact(month, "MMMM", CultureInfo.InvariantCulture).Month)
            {
                totalNetBalance += Convert.ToDouble(item.expense);
            }
        }
        Console.WriteLine(totalNetBalance);

    }

}

