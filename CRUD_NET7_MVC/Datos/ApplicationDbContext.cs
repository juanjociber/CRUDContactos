using CRUD_NET7_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_NET7_MVC.Datos
{
    public class ApplicationDbContext: DbContext
    {
        //Creando archivo de contexto
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //Espacio para los modelos 
        public DbSet<Contacto> Contacto {  get; set; }

    }
}
