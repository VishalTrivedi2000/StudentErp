using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMNEVH.Models.PopUps
{
   public enum PMessageType
    {
        GOOD,BAD,ERROR,WARNING
    }
    public class PMessage 
    {
        public PMessageType messageType { get; internal set; }
        public string messageHeader { get; internal set; }
        public string messageBody { get; internal set; }
        public string messageFooter { get; internal set; }
        public string backURL { get; internal set; }
    }
}