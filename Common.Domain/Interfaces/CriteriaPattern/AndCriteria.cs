using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain.Interfaces.CriteriaPattern
{
    internal class AndCriteria<TEntity> : ICriteria<TEntity>
    {
        private ICriteria<TEntity> Criteria { get; }
        private ICriteria<TEntity> OtherCriteria { get; }

        internal AndCriteria(ICriteria<TEntity> criteria, ICriteria<TEntity> otherCriteria)
        { 
            this.Criteria = criteria;
            this.OtherCriteria = otherCriteria;
        }
           
        public IList<TEntity> MeetCriteria(IList<TEntity> entities)
        {
            var result = this.Criteria.MeetCriteria(entities);
            if (result.Count == 0/* || result.Count == 1*/)
            {
                return result;
            }
            else
            { 
                return this.OtherCriteria.MeetCriteria(result);
            }
        }

    }
}
