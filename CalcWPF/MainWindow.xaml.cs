using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace CalcWPF
{
    public partial class MainWindow : Window
    {
        string rightop = "";//правый операнд
        string leftop = "";//левый операнд
        string operation = "";//знак операции
        Regex regex = new Regex(@"^[1-9]\\d{1,2}$");

        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement c in LayoutRoot.Children)
            {
                if (c is Button)
                {
                    ((Button)c).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = (string)((Button)e.OriginalSource).Content;//получаем текст кнопки
            if (textBlock.Text.StartsWith("0") && leftop != "0")
            {
                textBlock.Text = "";
            }
            textBlock.Text += s;
            int num;
            bool result = Int32.TryParse(s, out num);//пытаемся преобразовать текст в число     
            if (result == true)//если введено число
            {
                if (operation == "")
                {
                    leftop += s;
                }
                else
                {
                    rightop += s;//добавляем к правому операнду
                }
            }
            else//если было введено не число
            {
                if (s == "=")
                {
                    Update_RightOp();
                    textBlock.Text += rightop;
                    operation = "";
                }
                else if (s == "CLEAR")//очистка переменных и поля
                {
                    leftop = "";
                    rightop = "";
                    operation = "";
                    textBlock.Text = "0";
                }
                else if (s == "DEL")//очистка последних введенных данных
                {
                    if (operation == "" && !leftop.Equals(""))
                    {
                        leftop = leftop.Remove(leftop.Length - 1);
                        textBlock.Text = leftop;
                    }
                    else if (!rightop.Equals(""))
                    {
                        rightop = rightop.Replace(rightop.Last(), ' ');
                        textBlock.Text = leftop + operation + rightop;
                    }
                    if (leftop.Equals("") || leftop.Equals(""))
                    {
                        textBlock.Text = "0";
                    }
                }
                else if (s == "+/-")//задаем положительный или отрицательный знак числа
                {
                    try
                    {
                        if (operation == "")
                        {
                            if (leftop[0] != '-') leftop = leftop.Insert(0, "-");
                            else leftop = leftop.Replace("-", " ");
                            textBlock.Text = leftop;
                        }
                        else
                        {
                            if (rightop[0] != '-') rightop = rightop.Insert(0, "-");
                            else rightop = rightop.Replace("-", " ");
                            textBlock.Text = leftop + operation + '(' + rightop + ')';
                        }
                    }
                    catch
                    {
                        leftop = rightop = "";
                        textBlock.Text = "0";
                        MessageBox.Show("Чтобы указать знак числа, необходимо ввести число.");
                    }
                }
                else if (s == "1/x")
                {
                    try
                    {
                        if (leftop != "0")
                        {
                            double number = double.Parse(leftop);
                            if (number != 0)
                            {
                                leftop = Math.Pow(number, -1).ToString();
                                textBlock.Text = leftop;
                            }
                        }
                        else
                        {
                            leftop = rightop = "";
                            textBlock.Text = "0";
                            MessageBox.Show("Деление на ноль.", "Ошибка.");
                        }
                    }
                    catch
                    {
                        leftop = rightop = "";
                        textBlock.Text = "0";
                        MessageBox.Show("Введите число.");
                    }
                }
                else if (s == "n!")
                {
                    try
                    {
                        double number = double.Parse(leftop);
                        int digit = 1;
                        for (int i = 2; i <= number; i++) digit *= i;
                        if (digit < int.MaxValue)
                            leftop = digit.ToString();
                        textBlock.Text = leftop;
                    }
                    catch
                    {
                        textBlock.Text = "0";
                        MessageBox.Show("Введите число.");
                    }
                }
                else if (s == "√")
                {
                    try
                    {
                        double n = double.Parse(leftop);
                        if (n >= 0)
                        {
                            leftop = Math.Sqrt(n).ToString();
                            textBlock.Text = leftop;
                        }
                        else
                        {
                            leftop = rightop = "";
                            textBlock.Text = "0";
                            MessageBox.Show("Невозможно выполнить операцию '√' для отрицательного числа.", "Ошибка.");
                        }
                    }
                    catch
                    {
                        textBlock.Text = "0";
                        MessageBox.Show("Введите число.");

                    }
                }
                else if (s == "x^2")
                {
                    try
                    {
                        if (rightop == "")
                        {
                            int number = int.Parse(leftop);
                            int digit = number * number;
                            if (digit < int.MaxValue)
                                leftop = digit.ToString();
                            textBlock.Text = leftop;
                        }
                        else
                        {
                            int number = int.Parse(rightop);
                            int digit = number * number;
                            if (digit < int.MaxValue)
                                rightop = digit.ToString();
                            textBlock.Text = rightop;
                        }
                    }
                    catch
                    {
                        textBlock.Text = "0";
                        MessageBox.Show("Введите число.");

                    }
                }
                else if (s == "sin")
                {
                    try
                    {
                        double number = double.Parse(leftop);
                        leftop = Math.Sin(number).ToString();
                        textBlock.Text = leftop;
                    }
                    catch
                    {
                        if (leftop == "" || leftop == "0")
                        {
                            textBlock.Text = "0";
                            MessageBox.Show("Введите число.");
                        }
                    }
                }
                else if (s == "cos")
                {
                    try
                    {
                        double number = double.Parse(leftop);
                        leftop = Math.Cos(number).ToString();
                        textBlock.Text = leftop;
                    }
                    catch
                    {
                        if (leftop == "" || leftop == "0")
                        {
                            textBlock.Text = "0";
                            MessageBox.Show("Введите число.");
                        }
                    }
                }
                else if (s == "tan")
                {
                    try
                    {
                        double number = double.Parse(leftop);
                        leftop = Math.Tan(number).ToString();
                        textBlock.Text = leftop;
                    }
                    catch
                    {
                        if (leftop == "" || leftop == "0")
                        {
                            textBlock.Text = "0";
                            MessageBox.Show("введите число.");
                        }
                    }
                }
                else if (s == "e")
                {
                    if (leftop == "")
                    {
                        leftop = Math.Exp(1).ToString();
                        textBlock.Text = leftop;
                    }
                    else
                    {
                        rightop = Math.Exp(1).ToString();
                        textBlock.Text = rightop;
                    }
                }
                else if (s == "e^x")
                {
                    try
                    {
                        double number = double.Parse(leftop);
                        leftop = Math.Exp(number).ToString();
                        textBlock.Text = leftop;
                    }
                    catch
                    {
                        if (leftop == "" || leftop == "0")
                        {
                            textBlock.Text = "0";
                            MessageBox.Show("Введите степень числа.");
                        }
                    }
                }
                else if (s == "π")
                {
                    leftop = Math.PI.ToString();
                    textBlock.Text = leftop;
                }
                else//получаем операцию
                {
                    if (rightop != "")//если правый операнд уже имеется, то присваиваем его значение левому операнду, а правый очищаем
                    {
                        Update_RightOp();
                        leftop = rightop;
                        rightop = "";
                    }
                    operation = s;
                }
            }
        }

        private void Update_RightOp()//обновляем значение правого операнда
        {
            try
            {
                double num1 = Double.Parse(leftop);
                double num2 = Double.Parse(rightop);
                switch (operation)
                {
                    case "+":
                        rightop = (num1 + num2).ToString();
                        break;
                    case "-":
                        rightop = (num1 - num2).ToString();
                        break;
                    case "*":
                        rightop = (num1 * num2).ToString();
                        break;
                    case "/":
                        if (num2 != 0 && rightop!="0")
                            rightop = (num1 / num2).ToString();
                        else
                        {
                            MessageBox.Show("На ноль делить нельзя.");
                            Clear();
                        }
                        break;
                    case "MOD":
                        if (num2 != 0 && rightop != "0")
                            rightop = (num1 % num2).ToString();
                        else
                        {
                            MessageBox.Show("На ноль делить нельзя.");
                            Clear();
                        }
                        break;
                    case "DIV":
                        if (num2 != 0 && rightop != "0")
                            rightop = Math.Truncate((double)num1 / num2).ToString();
                        else
                        {
                            MessageBox.Show("На ноль делить нельзя.");
                            Clear();
                        }
                        break;
                    case "x^y":
                        rightop = Math.Pow(num1, num2).ToString();
                        break;
                }
            }
            catch
            {
                leftop = operation = rightop = "";
                textBlock.Text = "0";
                MessageBox.Show("Некорректный ввод исходных данных.", "Ошибка.");
            }
        }
        private void Clear()
        {
            leftop = "";
            rightop = "";
            operation = "";
            textBlock.Text = "0";
        }

    }
}

