using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto_API_Banco_Carrefour.Models;

namespace Projeto_API_Banco_Carrefour.Data
{
    public class DataContext : DbContext
    {     
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<EmpodeiramentoFEM> EmpodeiramentoFEMs { get; set;}
    }
}