using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASM_NguyenThanhduong.Models
{
    public class MyDbContext: DbContext
    {
        public MyDbContext() : base("name = SMSProjectConnectionString")
        {

        }
        public virtual DbSet<User> Users { get; set; }
    }
}