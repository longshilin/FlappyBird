//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ContextMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class ConfigurationMatcher {

    public static Entitas.IAllOfMatcher<ConfigurationEntity> AllOf(params int[] indices) {
        return Entitas.Matcher<ConfigurationEntity>.AllOf(indices);
    }

    public static Entitas.IAllOfMatcher<ConfigurationEntity> AllOf(params Entitas.IMatcher<ConfigurationEntity>[] matchers) {
          return Entitas.Matcher<ConfigurationEntity>.AllOf(matchers);
    }

    public static Entitas.IAnyOfMatcher<ConfigurationEntity> AnyOf(params int[] indices) {
          return Entitas.Matcher<ConfigurationEntity>.AnyOf(indices);
    }

    public static Entitas.IAnyOfMatcher<ConfigurationEntity> AnyOf(params Entitas.IMatcher<ConfigurationEntity>[] matchers) {
          return Entitas.Matcher<ConfigurationEntity>.AnyOf(matchers);
    }
}
