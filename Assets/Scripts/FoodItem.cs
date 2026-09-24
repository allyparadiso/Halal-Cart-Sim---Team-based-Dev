using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewFoodItem", menuName = "Scriptable Objects/New Food Item")] //right-click in the project section, click create, then click Scriptable Objects menu to add new dish
public class FoodItem : ScriptableObject
{
    public string foodName;
    [SerializeField] private string foodID;
    public float price;
    public Sprite foodIcon;
    public List<Ingredients> ingredients;

    private void OnValidate()
    {
        if (string.IsNullOrEmpty(foodID))
        {
            foodID = foodName + Guid.NewGuid().ToString();
        }
    }
}
