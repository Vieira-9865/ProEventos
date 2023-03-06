using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheApi.API.Models;

namespace TheApi.API.Data
{
    public class DataContext : DbContext
    {
        // Construtor para poder passar de Data Context para o DbContext que é o principal
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Evento> Eventos { get; set;}
    }
}