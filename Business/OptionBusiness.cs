using Holism.Business;
using Holism.DataAccess;
using Holism.Framework;
using Holism.Configuration.DataAccess;
using Holism.Configuration.Models;
using Microsoft.VisualBasic;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Holism.Configuration.Business
{
    public class OptionBusiness : Business<Option, Option>
    {
        
        protected override Repository<Option> WriteRepository => Repository.Option;

        protected override ReadRepository<Option> ReadRepository => Repository.Option;

    }
}
