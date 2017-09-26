using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC
{
    public abstract class viewer : Form
    {
        // connect with the controller so that we  can issue control commands
        protected Controller _ctrlr;
        public Controller MVC_controller
        {
            set { _ctrlr = value; }
            
        }

        //connect with the model so that we can access the data
        private Model _mdl;
        public Model MVC_model
        {
            set { this._mdl = value; }
            get { return this._mdl; }
        }
        abstract public void ValuesUpdated();

    }
}
