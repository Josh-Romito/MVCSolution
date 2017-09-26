/*************
 * Josh Romito
 * CP_330 Week 3 Lab
 * September 26
 * **************/

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

            //create a controller
            Controller ctrlr = new Controller();

            //create a model
            // --- you do this (just like making a controller)
            Model dataModel = new Model();

            //connect controller to issues form
            newIssueForm issueForm = new newIssueForm();
            issueForm.MVC_controller = ctrlr;

            //connect the model to the issue form
            issueForm.MVC_model = dataModel;

            //connect controller to resolution form
            resolutionForm resolveForm = new resolutionForm();
            resolveForm.MVC_controller = ctrlr;

            //connect the model to the resolve form
            resolveForm.MVC_model = dataModel;

            //we need to add the model to the existing controller
            ctrlr.MVC_model = dataModel;


            // need to add the two forms to the model using the addView function
            dataModel.addView(issueForm);
            dataModel.addView(resolveForm);

            resolveForm.Show();
            Application.Run(issueForm);
        }
    }
}
