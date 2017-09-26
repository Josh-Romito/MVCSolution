using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    public class Model
    {
        private int _count = 0;
        List<viewer> _forms = new List<viewer>();

        public void ChangeValue(int delta){
            _count += delta;
            AlertForChanges();
        }

        // need to be able to read the count publicly
        // property here
        public int GetCount()
        {
            return _count;
        }

        public void addView (viewer formToAdd) {
            _forms.Add(formToAdd);
        }

        public void AlertForChanges()
        {
            foreach(viewer v in _forms)
            {
                v.ValuesUpdated();
            }
        }
    }
}
