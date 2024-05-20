using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain.Interfaces.CriteriaPattern
{
    internal class NotCriteria<TEntity> : ICriteria<TEntity>
    {
        private ICriteria<TEntity> Criteria { get; }
        internal NotCriteria(ICriteria<TEntity> criteria) 
        {  
            this.Criteria = criteria; 
        }
        public IList<TEntity> MeetCriteria(IList<TEntity> entities)
        {
            var notCriteria = this.Criteria.MeetCriteria(entities);
            foreach (var entity in notCriteria)
            {
                entities.Remove(entity);
            }
            return entities;
        }
    }
}
