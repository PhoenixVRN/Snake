using UnityEngine;
using Entitas;
using UnityEditor.Timeline.Actions;

public class InitializeAppleSystem : IInitializeSystem
    {
        private Contexts _contexts;
        public InitializeAppleSystem(Contexts contexts)
        {
            _contexts = contexts;
        }
        public void Initialize()
        {
            var entity = _contexts.game.CreateEntity();
            entity.isApple = true;
            entity.AddResource(_contexts.game.gameSetup.value.laser);


            // var newPos = new Vector3(Random.Range((int)_contexts.game.gameSetup.value.leftUpBound.position.x,
            //         (int)_contexts.game.gameSetup.value.rightDownBound.position.x),
            //     Random.Range((int)_contexts.game.gameSetup.value.leftUpBound.position.y,
            //         (int)_contexts.game.gameSetup.value.rightDownBound.position.y));
            //
            entity.AddInitialPosition(new Vector3(Random.Range((int)-7, (int)7),
                Random.Range((int)-3, (int)3), 0f));
        }
    }
