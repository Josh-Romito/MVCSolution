/*************
 * Josh Romito
 * CP_330 Week 3 Lab
 * September 26
 * **************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    public class Controller
    {
        private Model _mdl;
        public Model MVC_model
        {
            set { _mdl = value; }
        }

        public void changeValue(int change){
            _mdl.ChangeValue(change);
        }
    }
}
