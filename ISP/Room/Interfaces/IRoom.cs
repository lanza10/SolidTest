﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Room.Interfaces
{
    public interface IRoom
    {
        string RoomId { get; set; }
        int RoomNumber { get; set; }
    }
}
