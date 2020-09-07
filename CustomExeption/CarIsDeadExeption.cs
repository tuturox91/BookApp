using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExeption
{
    [Serializable]
    class CarIsDeadExeption : ApplicationException
    {
        //public CarIsDeadExeption() { }
        //public CarIsDeadExeption(string message) : base(message) { }
        //public CarIsDeadExeption(string message, System.Exception inner)
        //    : base(message, inner) { }
        //private CarIsDeadExeption(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        //    :base(info, context){ }



        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOFError { get; set; }

        public CarIsDeadExeption() { }
        public CarIsDeadExeption(string message, string cause, DateTime time)
            : base(message)
        {

            CauseOFError = cause;
            ErrorTimeStamp = time;
        }
    }


}
