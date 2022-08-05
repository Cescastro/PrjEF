using Microsoft.EntityFrameworkCore;
using prjef.Models;

namespace prjef;

public class TareasContext: DbContext
{
    public DbSet<Categoria> Categorias {get;set;}
    public DbSet<Tarea> Tareas { get; set; }

    public TareasContext(DbContextOptions<TareasContext> options): base(options)
    {
        
    }

//ESTO ES FLUENT API
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<Categoria> categoriasInit = new List<Categoria>();

        categoriasInit.Add(new Categoria(){
            CategoriaId = Guid.Parse("968d0c48-bfc4-4d6b-8776-38f06bf86adc"),
            Nombre = "Actividades Pendientes",
            Peso = 20,
        });

        categoriasInit.Add(new Categoria(){
            CategoriaId = Guid.Parse("968d0c48-bfc4-4d6b-8776-38f06bf86aec"),
            Nombre = "Actividades Personales",
            Peso = 50,
        });

        modelBuilder.Entity<Categoria>(categoria=>{
            categoria.ToTable("Categoria");
            categoria.HasKey(p=> p.CategoriaId);

            categoria.Property(p=> p.Nombre).IsRequired().HasMaxLength(150);
            categoria.Property(p=> p.Descripcion).IsRequired(false);
            categoria.Property(p=> p.Peso);

            categoria.HasData(categoriasInit);
        });


        List<Tarea> tareasInit = new List<Tarea>();

        tareasInit.Add(new Tarea(){
            TareaId = Guid.Parse("968d0c48-bfc4-4d6b-8776-38f06bf86aaa"),
            CategoriaId =  Guid.Parse("968d0c48-bfc4-4d6b-8776-38f06bf86adc"),
            PrioridadTarea = Prioridad.Media,
            Titulo ="Pago Servicios",
            FechaCreacion = DateTime.Now,
        });

        tareasInit.Add(new Tarea(){
            TareaId = Guid.Parse("968d0c48-bfc4-4d6b-8776-38f06bf86bbb"),
            CategoriaId =  Guid.Parse("968d0c48-bfc4-4d6b-8776-38f06bf86aec"),
            PrioridadTarea = Prioridad.Baja,
            Titulo ="Ver Serie Netflix",
            FechaCreacion = DateTime.Now,
        });


        modelBuilder.Entity<Tarea>(tarea=>{
            tarea.ToTable("Tarea");
            tarea.HasKey(p=> p.TareaId);
            tarea.HasOne(p=> p.Categoria).WithMany(p=> p.Tareas).HasForeignKey(p=>p.CategoriaId);
           

            tarea.Property(p=> p.Titulo).IsRequired().HasMaxLength(200);
            tarea.Property(p=> p.Descripcion).IsRequired(false);
            tarea.Property(p=> p.PrioridadTarea);
            tarea.Property(p=> p.FechaCreacion);
            tarea.Property(p=> p.UserNameCreacion).IsRequired(false);

            tarea.Ignore(p=> p.Resumen);

            tarea.HasData(tareasInit);
            
        });

    }
}