using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkG
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new HelloForm());
            //Application.Run(new LendingRates());
            //Application.Run(new POS());
            //Application.Run(new maxminiScores());
            //Application.Run(new StudentGrade());
            //Application.Run(new Computer());
            //Application.Run(new ArrayForm());
            Application.Run(new DoForWhile());

        }
    }
}
