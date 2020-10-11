//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public AnyGameLostListenerComponent anyGameLostListener { get { return (AnyGameLostListenerComponent)GetComponent(GameComponentsLookup.AnyGameLostListener); } }
    public bool hasAnyGameLostListener { get { return HasComponent(GameComponentsLookup.AnyGameLostListener); } }

    public void AddAnyGameLostListener(System.Collections.Generic.List<IAnyGameLostListener> newValue) {
        var index = GameComponentsLookup.AnyGameLostListener;
        var component = (AnyGameLostListenerComponent)CreateComponent(index, typeof(AnyGameLostListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceAnyGameLostListener(System.Collections.Generic.List<IAnyGameLostListener> newValue) {
        var index = GameComponentsLookup.AnyGameLostListener;
        var component = (AnyGameLostListenerComponent)CreateComponent(index, typeof(AnyGameLostListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveAnyGameLostListener() {
        RemoveComponent(GameComponentsLookup.AnyGameLostListener);
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
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherAnyGameLostListener;

    public static Entitas.IMatcher<GameEntity> AnyGameLostListener {
        get {
            if (_matcherAnyGameLostListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.AnyGameLostListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAnyGameLostListener = matcher;
            }

            return _matcherAnyGameLostListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddAnyGameLostListener(IAnyGameLostListener value) {
        var listeners = hasAnyGameLostListener
            ? anyGameLostListener.value
            : new System.Collections.Generic.List<IAnyGameLostListener>();
        listeners.Add(value);
        ReplaceAnyGameLostListener(listeners);
    }

    public void RemoveAnyGameLostListener(IAnyGameLostListener value, bool removeComponentWhenEmpty = true) {
        var listeners = anyGameLostListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveAnyGameLostListener();
        } else {
            ReplaceAnyGameLostListener(listeners);
        }
    }
}
