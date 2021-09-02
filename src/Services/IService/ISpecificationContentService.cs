using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;

namespace Services.IService
{
    public interface ISpecificationContentService
    {
        Task Insert(SpecificationContent specification);

        Task<SpecificationContent> GetById(int Id);

        IEnumerable<SpecificationContent> GetMany(int index, int size);
    }
}