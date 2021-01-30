﻿using AdminPanelService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanelService.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<ImageAvatar> ImageAvatar { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> db) : base(db)
        {

        }
    }
}
