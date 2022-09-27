using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public interface IRegionRepository
    {
        //Making in Asynchronous by adding Task in the starting of the IEnumerable...
       Task<IEnumerable<Region>> GetAll();
    }
}
