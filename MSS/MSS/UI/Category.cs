﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSS.UI
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }
        public Panel CategoryPanel()
        {
            return panelCategory;
        }
        private void Category_Load(object sender, EventArgs e)
        {

        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            new AddCategory().ShowDialog();
        }
    }
}
