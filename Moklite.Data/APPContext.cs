using Microsoft.EntityFrameworkCore;
using Moklite.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moklite.Data
{
    public class APPContext : DbContext
    {
        public APPContext(DbContextOptions<APPContext> options) : base(options) {

        }

        public DbSet<FileOnDatabaseModel> FileSOnDatabaseModel { get; set; }
        public DbSet<FileOnFileSystemModel> FileSOnFileSystemModel { get; set; }
    }
}
