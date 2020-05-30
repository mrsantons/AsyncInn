﻿using AsyncInn.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Web.Services
{
    public interface IHotelService
    {
        Task<List<HotelSummary>> GetHotels();
        Task<HotelSummary> GetHotelById();
    }
}