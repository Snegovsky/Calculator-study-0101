using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kolygina11gr_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader in_ = new StreamReader("C:\\Users\\stud\\source\\repos\\Kolygina11gr_Exam\\test.txt");
            StreamWriter out_ = new StreamWriter("C:\\Users\\stud\\source\\repos\\Kolygina11gr_Exam\\que.txt");

            Console.WriteLine("Введите своё ФИО");
            string name = Console.ReadLine();
            Console.WriteLine("Введите номер группы");
            string gr = Console.ReadLine();
            string que = in_.ReadLine();
            int res = 0;
            while (que != null)
            {
                out_.WriteLine(que);
                Console.WriteLine(que);
                for (int i = 0; i < 4; ++i)
                {
                    string varAns = in_.ReadLine();
                    Console.WriteLine(varAns);
                }
                string rightAns = in_.ReadLine();
                string answer = Console.ReadLine();
                if (answer == rightAns) res++;
                que = in_.ReadLine();

            }
            Console.WriteLine($"Балл: {res}");
            File.AppendAllText("C:\\Users\\stud\\source\\repos\\Kolygina11gr_Exam\\result.txt", $"{name} {gr} Балл: {res}\n");
            Console.ReadKey();
            out_.Flush();

            Console.WriteLine("Умножение");

        }
    }
}
