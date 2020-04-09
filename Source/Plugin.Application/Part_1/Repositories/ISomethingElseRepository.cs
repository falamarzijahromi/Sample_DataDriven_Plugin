using Plugin.Application.Part_1.Models;
using System.Threading.Tasks;

namespace Plugin.Application.Part_1.Repositories
{
    public interface ISomethingElseRepository
    {
        Task CreateSomethignElse(SomethingElseBySample somethingElse);
    }
}
