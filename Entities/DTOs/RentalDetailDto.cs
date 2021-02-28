﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto:IDto

    {
        public int DetailId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CarName { get; set; }
        public int DailyPrice { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int TotalPrice { get; set; }


    }
}
