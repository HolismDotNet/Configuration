namespace Configuration;

public class OptionBusiness : Business<Option, Option>
{
    protected override Repository<Option> WriteRepository => RepositoryOption;

    protected override ReadRepository<Option> ReadRepository => RepositoryOption;
}
