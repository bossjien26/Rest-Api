using System.Linq;
using System.Threading.Tasks;
using Entities;
using Enum;

namespace Services.Interface
{
    public interface IMetaDataService
    {
        Task Insert(MetaData metaData);

        void Update(MetaData metaData);

        Task<MetaData> GetById(int id);

        MetaData GetByCategory(MetaDataCategoryEnum category, int type);
    }
}