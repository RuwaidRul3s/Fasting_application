using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Fasting_Application
{
    public partial class Form1 : Form
    {
        Thread t1;
        public Form1()
        {
            InitializeComponent();
        }

        private void SplashScreen_Tick(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t1 = new Thread(Show_Form2);
            t1.SetApartmentState(ApartmentState.MTA);
            t1.Start();
        }
        private void Show_Form2()
        {
            Thread.Sleep(500);
            this.Close();
            Application.Run(new MainScreen());
        }
    }
}
