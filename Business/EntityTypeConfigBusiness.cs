namespace Configuration;

public class EntityTypeConfigBusiness : Business<EntityTypeConfigView, EntityTypeConfig>
{
    protected override Read<EntityTypeConfigView> Read => Repository.EntityTypeConfigView;

    protected override Write<EntityTypeConfig> Write => Repository.EntityTypeConfig;
}