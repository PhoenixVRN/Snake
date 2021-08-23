using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class EatSystem : IExecuteSystem
{
    private Contexts _contexts;
    private IGroup<GameEntity> _group;
    public EatSystem(Contexts contexts)
    {
        _contexts = contexts;
        _group = contexts.game.GetGroup(GameMatcher.AllOf(
            GameMatcher.Collision));
    }

    public void Execute()
    {
        foreach (var entity in _group)
        {
            
            var first = entity.collision.first;
            var second = entity.collision.second;

            var firstEntity = _contexts.game.GetEntitiesWithView(first).SingleEntity();
            var S = _contexts.game.GetEntitiesWithView(second);
            if (second.gameObject.GetComponent<EmitTriggerEntityBehaviour>())
            {
                entity.isDestroy = true; 
                return;
            }
            if (S.Count > 0)
            {
                // находим entity на яблочко.
                var secondEntity = _contexts.game.GetEntitiesWithView(second).SingleEntity();
                //создаем новое яблочко.
                var newEntity = _contexts.game.CreateEntity();
                newEntity.isApple = true;
                newEntity.AddResource(_contexts.game.gameSetup.value.laser);

                newEntity.AddInitialPosition(
                    new Vector3(Random.Range((int)-7, (int)7),
                        Random.Range((int)-3, (int)3), 0f));

                firstEntity.score.value++;
                

                var entityTail = _contexts.game.CreateEntity();
//                entityTail.isPlayer = true;
                entityTail.AddResource(_contexts.game.gameSetup.value.player);
                entityTail.AddInitialPosition(second.transform.position);
                entityTail.AddAcceleration(second.transform.position);
                entityTail.AddSpeedRun(0.5f);
                entityTail.AddDirectionTravel(1);
                entityTail.isTail = true;
                
                var data = firstEntity.dataTile.DataTile;
                data.Add(entityTail);
                
                secondEntity.isDestroy = true;
                entity.isDestroy = true;

//                   return;
                
            }
 //           var secondEntity = _contexts.game.GetEntitiesWithView(second).SingleEntity();
         

            
            // var entityGO = _contexts.game.CreateEntity();
            // entityGO.isGameOver = true;
            //   entity.isDestroy = true;
        }
    }
}