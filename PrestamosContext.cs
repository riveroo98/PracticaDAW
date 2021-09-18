using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using prestasmosApi.Models;


namespace prestamosApi
{
    public class prestamosContext : DbContext
    {
        public prestamosContext(DbContextOption<prestamosContext> options) : base(options)
        {
        
        }
    }
}