﻿/*************
 * Josh Romito
 * CP_330 Week 3 Lab
 * September 26
 * **************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC
{
    public partial class newIssueForm : Viewer
    {

        public newIssueForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // inform the controller that there was a new issue (add one issue from the count of issues)
            _ctrlr.changeValue(1);
            // remember: we do not change to the model
        }

        //override values updated - and update label with value from model
        public override void ValuesUpdated()
        {
            resolutionCountLabel.Text = "Issues submitted: " + MVC_model.GetCount().ToString();
        }
    }
}
