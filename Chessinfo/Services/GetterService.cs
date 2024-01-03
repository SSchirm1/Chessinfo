using Chessinfo.Data;
using Chessinfo.Models;
using Microsoft.EntityFrameworkCore;

namespace Chessinfo.Services
{
    public class GetterService : IGetterService
    {
        public readonly ChessinfoContext _context;
        public GetterService(ChessinfoContext context) { 
            _context = context;

        }

        public List<T> GetAll<T>() where T : class
        {
            return _context.Set<T>().ToList();
        }

        public T GetSingle<T>(Func<T, bool> predicate) where T : class
        {
            return _context.Set<T>().SingleOrDefault(predicate);
        }
    }
}
