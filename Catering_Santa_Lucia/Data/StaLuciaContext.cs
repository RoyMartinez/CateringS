using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Catering_Santa_Lucia.Models;

namespace Catering_Santa_Lucia.Data
{
    public partial class StaLuciaContext : DbContext
    {
        public StaLuciaContext()
        {
        }

        public StaLuciaContext(DbContextOptions<StaLuciaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Horario> Horario { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Mesero> Mesero { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<PedidoMenus> PedidoMenus { get; set; }
        public virtual DbSet<Plato> Plato { get; set; }
        public virtual DbSet<PlatoServicio> PlatoServicio { get; set; }
        public virtual DbSet<Servicio> Servicio { get; set; }
        public virtual DbSet<TipoCliente> TipoCliente { get; set; }
        public virtual DbSet<TipoMenu> TipoMenu { get; set; }
        public virtual DbSet<TipoPedido> TipoPedido { get; set; }
        public virtual DbSet<TipoPlato> TipoPlato { get; set; }
        public virtual DbSet<TipoServicio> TipoServicio { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-RBJP8N8\\SQLEXPRESS;Initial Catalog=Sta_Lucia_Catering;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.Property(e => e.Direccion).HasMaxLength(400);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Encargado).HasMaxLength(200);

                entity.Property(e => e.Identificacion).HasMaxLength(30);

                entity.Property(e => e.Nombre).HasMaxLength(200);

                entity.Property(e => e.Telefono).HasMaxLength(20);

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.Tipo)
                    .HasConstraintName("Fk_Tipo");
            });

            modelBuilder.Entity<Horario>(entity =>
            {
                entity.HasKey(e => new { e.Pedido, e.Mesero })
                    .HasName("Pk_Horario");

                entity.HasOne(d => d.MeseroNavigation)
                    .WithMany(p => p.Horario)
                    .HasForeignKey(d => d.Mesero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Horario_Mesero");

                entity.HasOne(d => d.PedidoNavigation)
                    .WithMany(p => p.Horario)
                    .HasForeignKey(d => d.Pedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Horario_Pedido");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p.Menu)
                    .HasForeignKey(d => d.Tipo)
                    .HasConstraintName("Fk_Tipo_Menu");
            });

            modelBuilder.Entity<Mesero>(entity =>
            {
                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("Fecha_Creacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaPedido)
                    .HasColumnName("Fecha_Pedido")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Pedido)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("Fk_Pedido_Cliente");

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p.Pedido)
                    .HasForeignKey(d => d.Tipo)
                    .HasConstraintName("Fk_Pedido_Tipo");

                entity.HasOne(d => d.UsuarioNavigation)
                    .WithMany(p => p.Pedido)
                    .HasForeignKey(d => d.Usuario)
                    .HasConstraintName("Fk_Pedido_Usuario");
            });

            modelBuilder.Entity<PedidoMenus>(entity =>
            {
                entity.HasKey(e => new { e.Pedido, e.Menu })
                    .HasName("Pk_Pedido_Menus");

                entity.ToTable("Pedido_Menus");

                entity.HasOne(d => d.MenuNavigation)
                    .WithMany(p => p.PedidoMenus)
                    .HasForeignKey(d => d.Menu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Menu_pedidomenu");

                entity.HasOne(d => d.PedidoNavigation)
                    .WithMany(p => p.PedidoMenus)
                    .HasForeignKey(d => d.Pedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Pedidos_pedidomenu");
            });

            modelBuilder.Entity<Plato>(entity =>
            {
                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p.Plato)
                    .HasForeignKey(d => d.Tipo)
                    .HasConstraintName("Fk_Tipo_Plato");
            });

            modelBuilder.Entity<PlatoServicio>(entity =>
            {
                entity.HasKey(e => new { e.Plato, e.Servicio })
                    .HasName("Pk_Plato_Servicio");

                entity.ToTable("Plato_Servicio");

                entity.Property(e => e.Dia).HasMaxLength(30);

                entity.HasOne(d => d.MenuNavigation)
                    .WithMany(p => p.PlatoServicio)
                    .HasForeignKey(d => d.Menu)
                    .HasConstraintName("Fk_Menu");

                entity.HasOne(d => d.PlatoNavigation)
                    .WithMany(p => p.PlatoServicio)
                    .HasForeignKey(d => d.Plato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plato");

                entity.HasOne(d => d.ServicioNavigation)
                    .WithMany(p => p.PlatoServicio)
                    .HasForeignKey(d => d.Servicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Servicio");
            });

            modelBuilder.Entity<Servicio>(entity =>
            {
                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p.Servicio)
                    .HasForeignKey(d => d.Tipo)
                    .HasConstraintName("Fk_Tipo_Servicio");
            });

            modelBuilder.Entity<TipoCliente>(entity =>
            {
                entity.ToTable("Tipo_Cliente");

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<TipoMenu>(entity =>
            {
                entity.ToTable("Tipo_Menu");

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<TipoPedido>(entity =>
            {
                entity.ToTable("Tipo_Pedido");

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<TipoPlato>(entity =>
            {
                entity.ToTable("Tipo_Plato");

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<TipoServicio>(entity =>
            {
                entity.ToTable("Tipo_Servicio");

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Contraseña).HasMaxLength(20);

                entity.Property(e => e.Nombre).HasMaxLength(20);

                entity.Property(e => e.Grupo).HasMaxLength(10);
            });
        }
    }
}
