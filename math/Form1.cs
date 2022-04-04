using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s = robox.Text;
                double roboxbox = Convert.ToDouble(s);
                status.Text = "Выполнено";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка", "Ошибка: \n" + ex.Message);
            }
            //start();
            status.Text = "Выполняю...";
        }
         /*public void start()
        {
            Form1 fact = new Form1();
            int n = 2, m;
            double trez, pk, alif, PO, sum, pup;
            if (robox.Text)
            double ro = System.Convert.ToDouble(robox.Text);
            double ro = 2.17, eps = 0.08; //ro - ро, eps - альфа из задачи (эпсилон)
            for (; n < 5; n++)
            {
                m = -1;
                pk = 1;
                sum = 1;
                trez = ro / n;
                double a = 1;
                for (int i = 1; i <= n; i++)
                {
                    a = a * n / i * trez;
                    sum += a;
                }
                double pks = 2;
                //int test;
                //test = fact.factorial(System.Convert.ToInt32(n));
                //Console.WriteLine();
                pup = Math.Pow(n, n) / fact.factorial(n) * Math.Pow(trez, n + 1) / (1 - trez);
                alif = Math.Pow(n, n) / fact.factorial(n) * Math.Pow(trez, n - 1);
                while (pk > eps && (Math.Abs(pk - pks) > 0.0000001))
                {
                    pks = pk;
                    m++;
                    PO = 1 / (sum + pup * (1 - Math.Pow(trez, m)));
                    alif *= trez;
                    pk = alif * PO;
                }
                if (Math.Abs(pk - pks) > 0.0000001)
                {
                    Console.WriteLine("n=" + n + " m=" + m);
                }
                else
                    Console.WriteLine("n=" + n + " m=infinite");
            }
        }*/
        public long factorial(long n)
        {
            long f = 1;
            for (int i = 2; i <= n; i++)
                f *= i;
            return f;
        }
    }
}
