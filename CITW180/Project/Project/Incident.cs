using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project
{
    public class Incident
    {
        public int IncidentID;
        public int CustomerID;
        public string ProductCode;
        public int TechID;
        public DateTime DateOpened;
        public DateTime DateClosed;
        public string Title;
        public string Description;
    }
}