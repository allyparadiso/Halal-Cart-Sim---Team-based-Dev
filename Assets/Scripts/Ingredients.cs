using System;
using UnityEngine;

//script for creating Ingredient scriptable objects

[CreateAssetMenu(fileName = "NewIngredient", menuName = "Scriptable Objects/New Ingredient")]
public class Ingredients : ScriptableObject
{
    public string ingredientName;
    public string ingredientID;
    public Sprite ingredientIcon;

    private void OnValidate()
    {
        if (string.IsNullOrEmpty(ingredientID))
        {
            ingredientID = ingredientName + Guid.NewGuid().ToString();
        }
    }
}
