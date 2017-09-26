using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // create a controller
            Controller ctrlr = new Controller();

            // create a model
            // --- you do this (just like making a controller)
            Model myModel = new Model();

            newIssueForm issueForm = new newIssueForm();
            issueForm.MVC_controller = ctrlr;
            // connect the model to the issue form
            issueForm.MVC_model = myModel;

            resolutionForm resolveForm = new resolutionForm();
            resolveForm.MVC_controller = ctrlr;
            // connect the model to the resolve form
            resolveForm.MVC_model = myModel;

            //we need to add the model to the existing controller
            ctrlr.MVC_model = myModel;


            // need to add the two forms to the model using the addView function
            myModel.addView(issueForm);
            myModel.addView(resolveForm);

            resolveForm.Show();
            Application.Run(issueForm);

        }
    }
}
