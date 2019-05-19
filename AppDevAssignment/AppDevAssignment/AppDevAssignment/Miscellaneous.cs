﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDevAssignment
{
    public partial class Miscellaneous : Form
    {
        public Miscellaneous()
        {
            InitializeComponent();
        }

        private void CowGoatMilkButton_Click(object sender, EventArgs e)
        {
            TaskCode.PrintIDToFile();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AppForms.mainMenu.Show();
            this.Hide();
            AppForms.mainMenuVisible = true;
        }

        private void Miscellaneous_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
