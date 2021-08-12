//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class GameComponentsLookup {

    public const int Acceleration = 0;
    public const int DirectionTravel = 1;
    public const int GameSetup = 2;
    public const int Health = 3;
    public const int InitialPosition = 4;
    public const int Input = 5;
    public const int Player = 6;
    public const int PositionComponet = 7;
    public const int Resource = 8;
    public const int SpeedRun = 9;
    public const int View = 10;

    public const int TotalComponents = 11;

    public static readonly string[] componentNames = {
        "Acceleration",
        "DirectionTravel",
        "GameSetup",
        "Health",
        "InitialPosition",
        "Input",
        "Player",
        "PositionComponet",
        "Resource",
        "SpeedRun",
        "View"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(AccelerationComponent),
        typeof(DirectionTravelComponent),
        typeof(GameSetupComponent),
        typeof(HealthComponent),
        typeof(InitialPositionComponent),
        typeof(PlayerComponent),
        typeof(PositionComponet),
        typeof(ResourceComponent),
        typeof(SpeedRunComponent),
        typeof(ViewComponent)
    };
}