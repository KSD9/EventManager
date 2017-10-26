using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EventManagementSystem.Model;

namespace EventManagementSystem.DB
{
    public class EventContext : DbContext
    {
        public EventContext()
            : base("name=EventContext")
        {
            Database.SetInitializer<EventContext>(new CreateDatabaseIfNotExists<EventContext>());
        }
        public virtual DbSet<Event> Events { get; set; }

    }
}
