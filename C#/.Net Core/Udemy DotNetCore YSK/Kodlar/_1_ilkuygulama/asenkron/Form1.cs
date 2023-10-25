using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asenkron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
                await Calistir1();
        }

        private Task Calistir1()
        {
            return Task.Run(() => { MessageBox.Show("Calistir 1 calisti"); });
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            await Calistir2();
        }
        private int ahmet()
        {
            return 1;
        }

        private Task Calistir2()
        {

            return Task.Run( () =>{ return 5; }) ;
        }
    }
}
