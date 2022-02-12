namespace Configuration;

public class OptionBusiness : Business<Option, Option>
{
    protected override Write<Option> Write => Repository.Option;

    protected override Read<Option> Read => Repository.Option;
}
