using UnityEngine;
using Entitas;

public class GameController : MonoBehaviour
{
    public GameSetup gameSetup;
    private Systems _systems;

    private void Start()
    {
        var contexts = Contexts.sharedInstance;

        contexts.game.SetGameSetup(gameSetup);

        _systems = CreateSystems(contexts);
        _systems.Initialize();
    }

    private void Update()
    {
        _systems.Execute();
    }

    private Systems CreateSystems(Contexts contexts)
    {
        return new Feature("Game")
                .Add(new InitializePlayerSystem(contexts))
                .Add(new InitializeAppleSystem(contexts))
                
                .Add(new InstantiateViewSystem(contexts))
            
                .Add(new InputSystem(contexts))
  //              .Add(new ReplaceAccelerationSystem(contexts))
                .Add(new MoveSystem(contexts))
                .Add(new EatSystem(contexts))
                .Add(new DestroySystem(contexts))
            ;
    }
}

