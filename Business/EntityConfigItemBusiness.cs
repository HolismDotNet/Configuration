namespace Configuration;

public class EntityConfigItemBusiness : Business<EntityConfigItemView, EntityConfigItem>
{
    protected override Read<EntityConfigItemView> Read => Repository.EntityConfigItemView;

    protected override Write<EntityConfigItem> Write => Repository.EntityConfigItem;
}