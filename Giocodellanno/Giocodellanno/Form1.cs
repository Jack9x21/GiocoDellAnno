﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giocodellanno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            //commento ciocchi
            //prova candi
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog(); // Mostra il form di login in modalità modale
            this.Hide();
        }
    }
}
