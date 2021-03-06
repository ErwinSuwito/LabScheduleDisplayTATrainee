﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Schedule_Display.DataLayers
{
    public class SearchResults : INotifyPropertyChanged
    {
        public string ModuleCode { get; set; }
        public DateTime UseDate { get; set; }
        public string LecturerName { get; set; }
        public string IntakeCode { get; set; }
        public string ModuleName { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string LabName { get; set; }
        public string LabLocation { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyEventChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
