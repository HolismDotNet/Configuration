﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Holism.Business;
using Holism.Configuration.DataAccess;
using Holism.Configuration.Models;
using Holism.DataAccess;
using Holism.Infra;
using Microsoft.VisualBasic;
using MoreLinq;

namespace Holism.Configuration.Business
{
    public class OptionBusiness : Business<Option, Option>
    {
        protected override Repository<Option> WriteRepository =>
            Repository.Option;

        protected override ReadRepository<Option> ReadRepository =>
            Repository.Option;
    }
}
