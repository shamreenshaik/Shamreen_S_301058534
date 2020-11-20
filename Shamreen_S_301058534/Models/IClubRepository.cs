using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shamreen_S_301058534.Models
{
    public interface IClubRepository
    {
        IEnumerable<Club> Clubs { get; }
    }
}