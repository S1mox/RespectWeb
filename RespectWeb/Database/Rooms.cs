﻿using System;
using System.Collections.Generic;

namespace RespectWeb.Database
{
    public partial class Rooms
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string InviteKey { get; set; }
        public string PathToLogo { get; set; }
    }
}
