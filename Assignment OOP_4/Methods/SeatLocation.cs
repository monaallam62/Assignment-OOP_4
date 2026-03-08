using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_OOP_4.Enum;

namespace Assignment_OOP_4.Methods
{
    #region SeatLocation Struct
    public struct SeatLocation
    {
        public TypeOfTicket Row { get; set; }
        public int Number { get; set; }

        public SeatLocation(TypeOfTicket row, int number)
        {
            Row = row;
            Number = number;
        }
        public override string ToString()
        {
            return $"{Row}-{Number}";
            ;
        }
    }
    #endregion
}
