using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Library3;

namespace Library2
{
    public class Context : DbContext
    {
        public IDbSet<Message> Message { get; set; }
    }
}
