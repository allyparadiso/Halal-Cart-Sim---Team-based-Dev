using System.Collections.Generic;
using UnityEngine;
using System.Linq;

//


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    //timer

    private void Awake()
    {
        instance = this;
    }
}
