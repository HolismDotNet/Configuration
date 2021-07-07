using Holism.Business;
using Holism.Configuration.DataAccess;
using Holism.Configuration.Models;
using Holism.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Holism.Configuration.Business
{
    public class OptionBusiness : Business<Option, Option>
    {
        protected override Repository<Option> WriteRepository => RepositoryFactory.Option;

        protected override ViewRepository<Option> ReadRepository => RepositoryFactory.Option;
    }
}
