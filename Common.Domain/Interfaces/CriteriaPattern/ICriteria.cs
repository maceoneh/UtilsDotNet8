using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain.Interfaces.CriteriaPattern
{
    public interface ICriteria<TEntity>
    {
        IList<TEntity> MeetCriteria(IList<TEntity> entities);
    }
}
