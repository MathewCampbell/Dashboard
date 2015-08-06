using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dashboard.Domain.Entities;

namespace Dashboard.Domain.Abstract
{
    public interface IHealthBoardRepository
    {
        IEnumerable<HealthBoard> HealthBoards { get; } 
    }
}
