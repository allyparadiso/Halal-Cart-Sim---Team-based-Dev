using System;
using System.Collections.Generic;
using UnityEngine;

//script for creating Drink scriptable objects

[CreateAssetMenu(fileName = "NewDrink", menuName = "Scriptable Objects/New Drink")]
public class Drinks : ScriptableObject
{
    public string drinkName;
    public string drinkID;
    public float price;
    public Sprite drinkIcon;

    private void OnValidate()
    {
        if (string.IsNullOrEmpty(drinkID))
        {
            drinkID = drinkName + Guid.NewGuid().ToString();
        }
    }
}
