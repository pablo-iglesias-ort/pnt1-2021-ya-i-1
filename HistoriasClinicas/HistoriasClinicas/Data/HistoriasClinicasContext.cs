using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HistoriasClinicas.Models.Entidades;

namespace HistoriasClinicas.Data
{
    public class HistoriasClinicasContext : DbContext
    {
        public HistoriasClinicasContext (DbContextOptions<HistoriasClinicasContext> options)
            : base(options)
        {
        }

        public DbSet<HistoriasClinicas.Models.Entidades.Usuario> Usuario { get; set; }

        public DbSet<HistoriasClinicas.Models.Entidades.Medico> Medico { get; set; }

        public DbSet<HistoriasClinicas.Models.Entidades.Paciente> Paciente { get; set; }
    }
}
