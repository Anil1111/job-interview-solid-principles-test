﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerryTerminal
{
    enum VehicleType
    {
        Bus,
        Car,
        Truck,
        Van,
        Electric,
        Hybrid,
    }

    interface IVehicle
    {
        VehicleType VehicleType { get; set; }
    }
}
