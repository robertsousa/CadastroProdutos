﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroProdutos.Forms
{
    public partial class FormCadastroProdutos : Form
    {
        public FormCadastroProdutos()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FormAddProduct formAddProduct = new FormAddProduct();   
            formAddProduct.ShowDialog();
        }
    }
}
