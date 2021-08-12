using Entitas;
using UnityEngine;

public class InputSystem : IExecuteSystem
{
    private Contexts _contexts;

    public InputSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Execute()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _contexts.game.playerEntity.directionTravel.value = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            _contexts.game.playerEntity.directionTravel.value = 3;
        }
        if (Input.GetKey(KeyCode.D))
        {
            _contexts.game.playerEntity.directionTravel.value = 2;
        }
        if (Input.GetKey(KeyCode.A))
        {
            _contexts.game.playerEntity.directionTravel.value = 4;
        }
    }
}