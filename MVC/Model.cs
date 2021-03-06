﻿/*************
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
    public class Model
    {
        private int _count = 0;

        //list of viewers
        List<Viewer> _viewers = new List<Viewer>();

        public void ChangeValue(int delta){
            _count += delta;
            AlertForChanges();
        }

        //Added method to return count
        public int GetCount()
        {
            return _count;
        }

        //method to add viewer object to view list
        public void addView (Viewer viewer) {
            _viewers.Add(viewer);
        }


        public void AlertForChanges()
        {
            //foreach viewer
            foreach (Viewer v in _viewers)
            {
                //call ValuesUpdated
                v.ValuesUpdated();
            }
        }
    }
}
