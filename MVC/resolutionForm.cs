/*************
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
using System.Diagnostics;

namespace MVC
{
    public partial class resolutionForm : Viewer
    {

        public resolutionForm()
        {
            InitializeComponent();
        }

        //override values updated - and update label with value from model
        public override void ValuesUpdated()
        {
            resolutionCountLabel.Text = "Issues to resolve: " + MVC_model.GetCount().ToString();
        }


        private void resolveIssueButton_Click(object sender, EventArgs e)
        {
            // inform the controller that there was a resolution (removing one issue from the count of issues)
            _ctrlr.changeValue(-1);
            // remember: we do not change to the model
        }


        private void resolutionCountLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
