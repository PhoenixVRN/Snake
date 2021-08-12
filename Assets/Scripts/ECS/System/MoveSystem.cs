using UnityEngine;
using Entitas;

public class MoveSystem : IExecuteSystem
{
    private Contexts _contexts;
    private IGroup<GameEntity> _group;
    public MoveSystem(Contexts contexts)
    {
        _contexts = contexts;
        _group = contexts.game.GetGroup(GameMatcher.AllOf(
            GameMatcher.Acceleration, GameMatcher.Player));
    }

    public void Execute()
    {
        foreach(var entity in _group)
        {
            entity.speedRun.value -= Time.deltaTime;
            if (entity.speedRun.value <= 0)
            {
                if (entity.directionTravel.value == 1)
                {
                    var view = entity.view.value;
                    var position = view.transform.position;
                    position += Vector3.up;
                    view.transform.position = position;
                    entity.speedRun.value = 0.5f;
                }
                if (entity.directionTravel.value == 3)
                {
                    var view = entity.view.value;
                    var position = view.transform.position;
                    position += Vector3.down;
                    view.transform.position = position;
                    entity.speedRun.value = 0.5f;
                }
                if (entity.directionTravel.value == 2)
                {
                    var view = entity.view.value;
                    var position = view.transform.position;
                    position += Vector3.right;
                    view.transform.position = position;
                    entity.speedRun.value = 0.5f;
                }
                if (entity.directionTravel.value == 4)
                {
                    var view = entity.view.value;
                    var position = view.transform.position;
                    position += Vector3.left;
                    view.transform.position = position;
                    entity.speedRun.value = 0.5f;
                }
                
            }
            
        }
    }
}