﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class Inicio : Form
    {
        public Inicio(string nombre)
        {
            InitializeComponent();
            lbUsername.Text = nombre;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
