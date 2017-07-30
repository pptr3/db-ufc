﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbUFC
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            SetVisibleAddAtletaButton(true);
        }

        private void AddAtletaButton_Click(object sender, EventArgs e)
        {
            SetVisibleAddAtletaButton(true);
        }

        private void SetVisibleAddAtletaButton(bool value)
        {
            FormAddAtleta form2 = new FormAddAtleta();
            form2.Visible = value;
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            SetVisibleAddSponsorButton(true);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            SetVisibleAddSponsorButton(true);
        }

        private void SetVisibleAddSponsorButton(bool value)
        {
            FormAddSponsor sponsor = new FormAddSponsor();
            sponsor.Visible = value;
        }
    }
}