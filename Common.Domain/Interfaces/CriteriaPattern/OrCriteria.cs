using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain.Interfaces.CriteriaPattern
{
    internal class OrCriteria<TEntity> : ICriteria<TEntity>
    {
        private ICriteria<TEntity> Criteria { get; }
        private ICriteria<TEntity> OtherCriteria { get; }
        internal OrCriteria(ICriteria<TEntity> criteria, ICriteria<TEntity> otherCriteria)
        { 
            this.Criteria = criteria;
            this.OtherCriteria = otherCriteria;
        }
        public IList<TEntity> MeetCriteria(IList<TEntity> entities)
        {
            var first = this.Criteria.MeetCriteria(entities);
            var last = this.OtherCriteria.MeetCriteria(entities);
            foreach ( var entity in last ) { 
                if (!first.Contains(entity))
                {
                    first.Add(entity);
                }
            }
            return first;
        }
    }
}
