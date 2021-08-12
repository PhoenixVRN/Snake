using UnityEngine;
using Entitas.CodeGeneration.Attributes;


[Game, Unique]
[CreateAssetMenu(fileName = "GameSetup", menuName = "Create")]
public class GameSetup : ScriptableObject
{
    public GameObject player;
    public GameObject laser;
    public float rotationSpeed = 180f;
    public float playerMovementSpeed = 5f;
    public float laserSpeed = 10f;
    public float asteroidSpeed = 0.3f;

   

}