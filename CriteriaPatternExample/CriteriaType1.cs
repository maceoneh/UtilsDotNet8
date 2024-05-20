﻿using Common.Domain.Interfaces.CriteriaPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriteriaPatternExample
{
    internal class CriteriaType1 : ICriteria<Test>
    {
        public IList<Test> MeetCriteria(IList<Test> entities)
        {
            return entities.Where(e => e.Type == 1).ToList();
        }
    }
}
