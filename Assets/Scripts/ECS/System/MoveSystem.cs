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
        foreach (var entity in _group)
        {
            var enityHead = entity.view.value.transform.position;
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

             var   dataTail = entity.dataTile.DataTile;
             foreach (var tile in dataTail)
             {
                 var secondData = tile.view.value.transform.position;
                 var view = tile.view.value;
                 var position = view.transform.position;
                 view.transform.position = enityHead;
                 enityHead = secondData;
             }

            }
            
            
        }
    }
}