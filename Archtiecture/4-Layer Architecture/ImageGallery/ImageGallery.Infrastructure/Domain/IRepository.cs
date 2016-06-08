using System.Collections.Generic;

namespace ImageGallery.Infrastructure.Domain
{
    public interface IRepository<TModel, TKey> where TModel : ModelBase<TKey>
    {
        TModel Get(TKey id);
        IEnumerable<TModel> Find(string text);
        bool Save(TModel model);
        bool Update(TModel model);
        bool Delete(TModel model);
    }
}
