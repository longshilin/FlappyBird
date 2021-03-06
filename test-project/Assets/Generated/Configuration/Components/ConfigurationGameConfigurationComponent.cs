//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ConfigurationContext {

    public ConfigurationEntity gameConfigurationEntity { get { return GetGroup(ConfigurationMatcher.GameConfiguration).GetSingleEntity(); } }
    public GameConfigurationComponent gameConfiguration { get { return gameConfigurationEntity.gameConfiguration; } }
    public bool hasGameConfiguration { get { return gameConfigurationEntity != null; } }

    public ConfigurationEntity SetGameConfiguration(Configuration.IGameConfiguration newValue) {
        if (hasGameConfiguration) {
            throw new Entitas.EntitasException("Could not set GameConfiguration!\n" + this + " already has an entity with GameConfigurationComponent!",
                "You should check if the context already has a gameConfigurationEntity before setting it or use context.ReplaceGameConfiguration().");
        }
        var entity = CreateEntity();
        entity.AddGameConfiguration(newValue);
        return entity;
    }

    public void ReplaceGameConfiguration(Configuration.IGameConfiguration newValue) {
        var entity = gameConfigurationEntity;
        if (entity == null) {
            entity = SetGameConfiguration(newValue);
        } else {
            entity.ReplaceGameConfiguration(newValue);
        }
    }

    public void RemoveGameConfiguration() {
        gameConfigurationEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ConfigurationEntity {

    public GameConfigurationComponent gameConfiguration { get { return (GameConfigurationComponent)GetComponent(ConfigurationComponentsLookup.GameConfiguration); } }
    public bool hasGameConfiguration { get { return HasComponent(ConfigurationComponentsLookup.GameConfiguration); } }

    public void AddGameConfiguration(Configuration.IGameConfiguration newValue) {
        var index = ConfigurationComponentsLookup.GameConfiguration;
        var component = (GameConfigurationComponent)CreateComponent(index, typeof(GameConfigurationComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceGameConfiguration(Configuration.IGameConfiguration newValue) {
        var index = ConfigurationComponentsLookup.GameConfiguration;
        var component = (GameConfigurationComponent)CreateComponent(index, typeof(GameConfigurationComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveGameConfiguration() {
        RemoveComponent(ConfigurationComponentsLookup.GameConfiguration);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class ConfigurationMatcher {

    static Entitas.IMatcher<ConfigurationEntity> _matcherGameConfiguration;

    public static Entitas.IMatcher<ConfigurationEntity> GameConfiguration {
        get {
            if (_matcherGameConfiguration == null) {
                var matcher = (Entitas.Matcher<ConfigurationEntity>)Entitas.Matcher<ConfigurationEntity>.AllOf(ConfigurationComponentsLookup.GameConfiguration);
                matcher.componentNames = ConfigurationComponentsLookup.componentNames;
                _matcherGameConfiguration = matcher;
            }

            return _matcherGameConfiguration;
        }
    }
}
