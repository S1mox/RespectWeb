using System;
using System.Collections.Generic;

namespace RespectWeb.Database
{
    public partial class Points
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoomId { get; set; }
        public int Value { get; set; }
    }
}
