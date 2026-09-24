using System;
using UnityEngine;

[CreateAssetMenu(fileName = "NewIngredient", menuName = "Scriptable Objects/New Ingredient")]
public class Ingredients : ScriptableObject
{
    public string ingredientName;
    [SerializeField] private string ingredientID;
    public Sprite ingredientIcon;

    private void OnValidate()
    {
        if (string.IsNullOrEmpty(ingredientID))
        {
            ingredientID = ingredientName + Guid.NewGuid().ToString();
        }
    }
}
