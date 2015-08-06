using Dashboard.Domain.Abstract;
using Dashboard.Domain.Entities;
using System.Collections.Generic;
namespace Dashboard.Domain.Concrete 
{
    public class EFProductRepository : IHealthBoardRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<HealthBoard> HealthBoards
        {
            get { return context.Products; }
        }
    }
}