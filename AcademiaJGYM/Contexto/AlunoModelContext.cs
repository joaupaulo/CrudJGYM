using AcademiaJGYM.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademiaJGYM.Contexto
{
    public class AlunoModelContext : DbContext

    {

        public AlunoModelContext(DbContextOptions<AlunoModelContext> options) : base(options)
        {
            
        }


        public DbSet<Aluno> Aluno { get; set; }

    }
}
