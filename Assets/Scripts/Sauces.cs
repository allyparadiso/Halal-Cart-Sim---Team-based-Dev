using System;
using UnityEngine;

//script for creating Sauce scriptable objects


[CreateAssetMenu(fileName = "NewSauce", menuName = "Scriptable Objects/New Sauce")]
public class Sauces : ScriptableObject
{
    public string sauceName;
    public string sauceID;
    public Sprite sauceIcon;

    private void OnValidate()
    {
        if (string.IsNullOrEmpty(sauceID))
        {
            sauceID = sauceName + Guid.NewGuid().ToString();
        }
    }
}
