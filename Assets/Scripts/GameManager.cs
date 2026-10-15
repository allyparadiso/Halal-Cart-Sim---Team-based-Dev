using System.Collections.Generic;
using UnityEngine;
using System.Linq;

// Placed on the GameManager object in scene.
// Used to manage the Game State.

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }
}
