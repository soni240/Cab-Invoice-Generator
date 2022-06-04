﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC2_andUC3_Multiple_Rides
{
    public class InvoiceSummary
    {
        public int numOfRides;
        public double totalFare;
        public double avgFare;

        public InvoiceSummary(int numOfRides, double totalFare)
        {
            this.numOfRides = numOfRides;
            this.totalFare = totalFare;
            this.avgFare = totalFare / numOfRides;
        }
    }
}
