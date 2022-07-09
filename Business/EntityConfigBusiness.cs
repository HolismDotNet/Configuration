namespace Configuration;

public class EntityConfigBusiness : Business<EntityConfigView, EntityConfig>
{
    protected override Read<EntityConfigView> Read => Repository.EntityConfigView;

    protected override Write<EntityConfig> Write => Repository.EntityConfig;
}