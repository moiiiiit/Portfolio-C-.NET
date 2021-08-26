using System.Collections;
using System.Collections.Generic;
using System.Linq;
using portfolio_backend.models;

namespace portfolio_backend.data
{
    public class PortfolioRepoClass : PortfolioRepo
    {
        private readonly PortfolioContext _context;

        public PortfolioRepoClass(PortfolioContext context){
            _context = context;
        }
        public SortedList<int, int> mock(int userid)
        {
            SortedList<int, int> mockery = new SortedList<int, int>();
            mockery.Add(1, 2);
            mockery.Add(2, 3);
            mockery.Add(3, 4);
            mockery.Add(4, 5);
            return (mockery);
        }

        public User GetUser(int userid)
        {
            return _context.Users.FirstOrDefault(p => p.userid==userid);
        }
    }
}