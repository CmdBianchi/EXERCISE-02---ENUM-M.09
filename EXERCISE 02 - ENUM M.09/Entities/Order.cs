using System;
using EXERCISE_02___ENUM_M._09.Entities.Enums;
using EXERCISE_02___ENUM_M._09.Entities.Enums;
namespace EXERCISE_02___ENUM_M._09.Entities
{
    //------------------------------- START -------------------------------//
    class Order {
        
        public int Id{ get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString() {
            return Id + ", " + Moment + " ," + Status;
        }
    }
    //-------------------------------- END -------------------------------// 
}
