//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity tailEntity { get { return GetGroup(GameMatcher.Tail).GetSingleEntity(); } }

    public bool isTail {
        get { return tailEntity != null; }
        set {
            var entity = tailEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isTail = true;
                } else {
                    entity.Destroy();
                }
            }
        }
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
public partial class GameEntity {

    static readonly TailComponent tailComponent = new TailComponent();

    public bool isTail {
        get { return HasComponent(GameComponentsLookup.Tail); }
        set {
            if (value != isTail) {
                var index = GameComponentsLookup.Tail;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : tailComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherTail;

    public static Entitas.IMatcher<GameEntity> Tail {
        get {
            if (_matcherTail == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Tail);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTail = matcher;
            }

            return _matcherTail;
        }
    }
}
