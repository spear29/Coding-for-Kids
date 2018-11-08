//CODING FOR KIDS | mm/dd/yyyy | Developers: Zach, Sinan, Alexander, Hao, Todd
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CodingForKids
{

    //
    class CodingForKids
    {

    }

    // 3 choice lines per 1 question line/1 answers line
    class Database
    {
        string[] questions;
        string[] choices;
        string[] answers;

        public void Load()
        {
            questions = System.IO.File.ReadAllLines(@"C:\Users\TheRe\Documents\Visual Studio 2017\Projects\Coding for Kids\Coding for Kids\questions.txt");
            choices = System.IO.File.ReadAllLines(@"C:\Users\TheRe\Documents\Visual Studio 2017\Projects\Coding for Kids\Coding for Kids\choices.txt");
            answers = System.IO.File.ReadAllLines(@"C:\Users\TheRe\Documents\Visual Studio 2017\Projects\Coding for Kids\Coding for Kids\answers.txt");
        }

        public void Display()
        {
            foreach (string question in questions)
            {
                Console.WriteLine(question);
            }
            /*
             How to access answers.txt based on question number N

             i = 1;
             if(n == 1)
                return i;
             else
             {
                for(int j = 2; j <= n; j++)
                {
                    i += 3;
                }
             }
             */
        }
    }

    //
    class Interface
    {

    }

    //
    class Tutorial
    {

    }

    //
    class ExecuteGame
    {
        static void Main(string[] args)
        {
            //INTERFACE
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1()); //Form1 is Interface.cs, For some reason it didnt change.
            //INTERFACE
            Database d = new Database();
            d.Load();
            d.Display();
            Console.ReadKey(); // Hold the window.
        }
    }
}