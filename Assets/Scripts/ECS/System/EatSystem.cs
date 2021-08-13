using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class EatSystem : ReactiveSystem<GameEntity>
{
    private Contexts _contexts;
    public EatSystem(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Collision);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasCollision;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var entity in entities)
        {
            
            var first = entity.collision.first;
            var second = entity.collision.second;

            var firstEntity = _contexts.game.GetEntitiesWithView(first).SingleEntity();
            var S = _contexts.game.GetEntitiesWithView(second);
            if (S.Count > 0)
            {
                var secondEntity = _contexts.game.GetEntitiesWithView(second).SingleEntity();
                var newEntity = _contexts.game.CreateEntity();
                newEntity.isApple = true;
                newEntity.AddResource(_contexts.game.gameSetup.value.laser);

                newEntity.AddInitialPosition(
                    second.transform.position +
                    new Vector3(Random.Range((int)_contexts.game.gameSetup.value.leftUpBound.position.x,
                            (int)_contexts.game.gameSetup.value.rightDownBound.position.x),
                        Random.Range((int)_contexts.game.gameSetup.value.leftUpBound.position.y,
                            (int)_contexts.game.gameSetup.value.rightDownBound.position.y), 0f));
                
            


                secondEntity.isDestroy = true;
                entity.isDestroy = true;

                   return;
                
            }
 //           var secondEntity = _contexts.game.GetEntitiesWithView(second).SingleEntity();
         

            
            var entityGO = _contexts.game.CreateEntity();
            entityGO.isGameOver = true;
              entity.isDestroy = true;
        }
    }
}