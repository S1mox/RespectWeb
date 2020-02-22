using System;
using System.Collections.Generic;

namespace RespectWeb.Database
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string PathToImage { get; set; }
    }
}
