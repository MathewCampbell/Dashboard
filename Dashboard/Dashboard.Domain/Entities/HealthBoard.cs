using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Domain.Entities
{
    public class HealthBoard
    {
        public int HealthBoardId { get; set; }
        public string HealthBoardName { get; set; }
        public int StatusId { get; set; }
        public string Description { get; set; }
    }
}
