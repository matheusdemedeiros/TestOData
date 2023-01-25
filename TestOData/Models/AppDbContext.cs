﻿using Microsoft.EntityFrameworkCore;

namespace TestOData.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Escola> Escolas { get; set; }
        public DbSet<Aluno> Alunos { get; set; }

    }
}
