using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDayPlanner.NotesAndComments
{
    class ApplicationContext: DbContext
    {
        public ApplicationContext() : base("DefaultConnection")
        {

        }
        public DbSet<Note> notes { get; set; }
    }
}
