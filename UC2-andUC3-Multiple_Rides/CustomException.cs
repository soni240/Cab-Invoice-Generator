﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC2_andUC3_Multiple_Rides
{
    //custom Exception-Invalid Distance,Invalid Time
     public class CustomException:Exception
     {
        public ExceptionType type;
        public string message;

        public enum ExceptionType
        {
            INVALID_DISTANCE, INVALID_TIME, NULL_RIDES
        }
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
     }
}
