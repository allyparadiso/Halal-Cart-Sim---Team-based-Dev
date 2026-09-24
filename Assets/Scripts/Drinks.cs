using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewDrink", menuName = "Scriptable Objects/New Drink")]
public class Drinks : ScriptableObject
{
    public string drinkName;
    [SerializeField] private string drinkID;
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
