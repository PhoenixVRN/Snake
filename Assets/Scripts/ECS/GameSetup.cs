using UnityEngine;
using Entitas.CodeGeneration.Attributes;
using UnityEngine.Tilemaps;


[Game, Unique]
[CreateAssetMenu(fileName = "GameSetup", menuName = "CreateScriptObject")]
public class GameSetup : ScriptableObject
{
    public GameObject player;
    public GameObject laser;
    public GameObject Wall;
    
    public Transform leftUpBound;
   public Transform rightDownBound;
    
    public float rotationSpeed = 180f;
    public float playerMovementSpeed = 5f;
    public float laserSpeed = 10f;
    public float asteroidSpeed = 0.3f;

   

}