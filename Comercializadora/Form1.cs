﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Comercializadora.codigo;
using Comercializadora.formularios;

namespace Comercializadora
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            Application.Exit();


        }

        private void Button1_Click(object sender, EventArgs e)
        {
           // conexionbd conectar = new conexionbd();
            String usuario=txtUsuario.Text;
            String pass = txtPassword.Text;
            principal p = new principal();
            p.Show();

            
        }
    }
}
