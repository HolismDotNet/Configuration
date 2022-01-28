namespace Configuration;

public class OptionBusiness : Business<Option, Option>
{
    protected override Repository<Option> WriteRepository => Repository.Option;

    protected override ReadRepository<Option> ReadRepository => Repository.Option;
}
