using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shamreen_S_301058534.Models
{
    public class EFClubRepository : IClubRepository
    {
        private ApplicationDbContext context;

        public EFClubRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

     
      

        

        public IEnumerable<Club> Clubs => context.Clubs;
    }
}
