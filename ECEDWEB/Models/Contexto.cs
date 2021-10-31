﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECEDWEB.Models
{
    public class Contexto: DbContext
    {
        public DbSet<Aluno> aluno { get; set; }
        public Contexto(DbContextOptions<Contexto> opcoes): base(opcoes)
        {

        }
    }
}
