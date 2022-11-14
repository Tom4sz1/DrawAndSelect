﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DrawAndSelect
{
    internal class InkEditingModes : INotifyPropertyChanged
    {
        private InkCanvasEditingMode _EditingMode;
        public InkCanvasEditingMode EditingMode 
        {
            get
            {
                return _EditingMode;
            }
            set
            {
                _EditingMode = value;
                raiseEventThatPropertyChanged("EditingMode");
            } 
        }

        public void raiseEventThatPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
