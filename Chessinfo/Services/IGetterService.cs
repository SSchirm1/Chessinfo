namespace Chessinfo.Services
{
    public interface IGetterService
    {
        List<T> GetAll<T>() where T : class;

        T GetSingle<T>(Func<T, bool> predicate) where T : class;
    }
}