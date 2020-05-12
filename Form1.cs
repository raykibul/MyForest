using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyForest
{
    public partial class form1 : Form
    {
        decimal minute=0, hour=0, second=0;

        public form1()
        {
            InitializeComponent();
        }

        private void form1_Load(object sender, EventArgs e)
        {

            this.TopMost = true;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (workName.Text.Length == 0)
            {
                MessageBox.Show("Enter A Work Name");
                return;
            }
            if (numberPicker.Text.Length == 0)
            {
                MessageBox.Show("Enter Minute");
                return;
            }
            if(numberPicker.Value > 120)
            {
                MessageBox.Show("Max Minute: 120");
                return;
            }
            if (numberPicker.Value <10)
            { 
                MessageBox.Show("Min Minute: 10");
                return;
            }

            minute = numberPicker.Value-1;
            second = 60;
            timer1.Start();
             


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second--;

            if (second ==0)
            {
                second = 59;
                minute--;
                if (minute == 0)
                {
                    timer1.Stop();
                    timeStatus.Text = numberPicker.Value + "Min\n Completed!!";
                    return;
                }

            }
            timeStatus.Text = minute + ":" + second;
   
         
             

        }
    }
}
