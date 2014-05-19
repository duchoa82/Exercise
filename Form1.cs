using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Exercise.Csharp;



namespace Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /**
             * 
             * 
             * 
             */
            Student SvH = new Student();

            SvH.Namesv = "Hoa Khoai To";
            SvH.Password = "123a";
            MessageBox.Show(SvH.Password);
             
        
        }
    }
}
