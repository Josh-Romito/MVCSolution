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
    public partial class resolutionForm : viewer
    {

        public resolutionForm()
        {
            InitializeComponent();
        }

        public override void ValuesUpdated(){
            
            resolutionCountLabel.Text = MVC_model.GetCount().ToString();
        }

        private void resolutionCountLabel_Click(object sender, EventArgs e)
        {

        }

        private void resolveIssueButton_Click(object sender, EventArgs e)
        {
            // inform the controller that there was a resolution (removing one issue from the count of issues)
            _ctrlr.changeValue(-1);
            // remember: we do not change to the model
        }
    }
}
