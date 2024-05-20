using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain.Interfaces.CriteriaPattern
{
    public static class CriteriaExtensionMethods
    {
        public static ICriteria<TEntity> And<TEntity>(this ICriteria<TEntity> criteria, ICriteria<TEntity> otherCriteria)
        {
            return new AndCriteria<TEntity>(criteria, otherCriteria);
        }

        public static ICriteria<TEntity> Or<TEntity>(this ICriteria<TEntity> criteria, ICriteria<TEntity> otherCriteria)
        {
            return new OrCriteria<TEntity>(criteria, otherCriteria);
        }

        public static ICriteria<TEntity> Not<TEntity>(this ICriteria<TEntity> criteria)
        {
            return new NotCriteria<TEntity>(criteria);
        }
    }
}
