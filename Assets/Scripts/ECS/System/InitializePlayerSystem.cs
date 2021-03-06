using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class InitializePlayerSystem : IInitializeSystem
{
    private Contexts _contexts;
    public InitializePlayerSystem(Contexts contexts)
    {
        _contexts = contexts;
    }
    public void Initialize()
    {
        var entity = _contexts.game.CreateEntity();
        entity.isPlayer = true;
        entity.AddResource(_contexts.game.gameSetup.value.player);
        entity.AddPositionComponet(Vector3.zero);
        entity.AddAcceleration(Vector3.zero);
        entity.AddSpeedRun(0.5f);
        entity.AddDirectionTravel(1);
        entity.AddScore(0);
        
//        var entityData = _contexts.game.CreateEntity();
       entity.AddDataTile(new List<GameEntity>());
       var data = entity.dataTile.DataTile;
//       data.Add(entity);
        

    }
}