﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirepitAPI.DTO
{
    public class PhotoDTO
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public bool IsMain { get; set; }
        public bool IsApproved { get; set; }
    }
}
