using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Characters/Player")]
[RequireComponent(typeof(BoxCollider))]
public class Player : MonoBehaviour
{
    [Header("Player Stats")]
    [SerializeField]
    [Min(0)]
    private float playerHealth = 10f;

    [HideInInspector]
    public string playerName = "Joe";

    [SerializeField]
    [Range(10f, 100f)]
    float maxHealth = 20f;

    [Space]
    [SerializeField]
    [TextArea(1, 10)]
    string playerBio = "This is a Bio about Joe the Tools Programmer. He's an awesome guy and such.";

    [Header("Items")]
    [SerializeField]
    int numOfObjectsInInventory = 3;

    [SerializeField]
    int coins = 0;


    [Header("World Interactions")]
    [SerializeField]
    float distanceTraveled = 0f;

    [SerializeField]
    [Tooltip("This displays the amount of waves completed by the player to the Player UI Canvas.")]
    int enemyWavesCompleted = 0;

    [ContextMenu("Do Something")]
    public void DoSomething()
    {
        print("I did it!");
        GameObject newPlayer = new GameObject();
        newPlayer.AddComponent<Player>();
    }
}
