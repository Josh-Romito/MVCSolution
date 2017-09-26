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
    public partial class newIssueForm : viewer
    {
        // connect with the controller so that we can issue control commands
        //private Controller _ctrlr;
        //public Controller MVC_controller
        //{
        //    set { _ctrlr = value; }
        //}

        ////connect with the model so that we can access the data
        //private Model _mdl;
        //public Model MVC_model
        //{
        //    set { _mdl = value; }
        //}

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

        public override void ValuesUpdated()
        {
            resolutionCountLabel.Text = MVC_model.GetCount().ToString();
        }
    }
}
