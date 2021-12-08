using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double k;
            double b;
            LineFunction _LineFunction = new LineFunction();    

            Console.WriteLine("Решение уравнения вида  0=kx+b");
            Console.Write("Введите коэфициэнт к = ");
            k = Convert.ToDouble(Console.ReadLine());
            _LineFunction.K = k;
            Console.Write("Введите коэфициэнт b = ");
            b = Convert.ToDouble(Console.ReadLine());
            _LineFunction.B = b;


            if (_LineFunction.Root()) 
            {
                Console.Write("{0} {1}", _LineFunction.annotation, _LineFunction.X);
            }
            else 
            {
                Console.Write("{0}", _LineFunction.annotation);
            }

            Console.ReadKey();
        }
        class LineFunction
        { 
            private double k = 0;
            private double b = 0;
            private bool _true = false;
            private double x = 0;
            public string annotation = "";

            public double K
            {
                set
                {
                    this.k = value;
                }
                get { return this.k; }
            }
            public double B
            {
                set
                {
                    this.b = value;
                }
                get { return this.b; }
            }
            public double X
            {
                get 
                { 
                    return this.x; 
                }
            }
            public bool Root()
            {
                try // Оставил на всякий случай, хотя, похоже, для double это лишнее, достаточно цикла проверки на О, БУДУ БЛАГОДАРЕН ЗА ОТЗЫВ. 
                {
                    if (this.k != 0)
                    {
                        this.x = 0 - this.b / this.k;
                        this._true = true;
                        this.annotation = "Решение уравнения 0=KX+B : X = ";
                    }
                    else 
                    {
                        if (this.b == 0)
                        {
                            this._true = false;
                            this.annotation = "Решением уравнения 0=kx+b являчется вся числовая прямая.";
                            this.x = 0;
                        }
                        else
                        {
                            this._true = false;
                            this.annotation = "ПРИ ЗАДАННЫХ КОЭФФИЦИЭНТАХ УРАВНЕНИЕ 0=KX+B РЕШЕНИЙ НЕ ИМЕЕТ";
                            this.x = 0;
                        }
                    }
                    return _true;
                }
                catch 
                {
                    if ((b == 0) && (k == 0))
                    {
                        this.x = 0;
                        this._true = false;
                        this.annotation = "__Решением уравнения 0=kx+b являчется вся числовая прямая.";
                        return this._true;
                    }
                    else 
                    {
                        this.x = 0;
                        this._true = false;
                        this.annotation = "__ПРИ ЗАДАННЫХ КОЭФФИЦИЭНТАХ УРАВНЕНИЕ 0=KX+B РЕШЕНИЙ НЕ ИМЕЕТ";
                        return this._true;
                    }
                }
            }
        }
    }
}
