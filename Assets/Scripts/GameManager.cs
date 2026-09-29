using NUnit.Framework;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //timer
    //check if order is correct
    [SerializeField] private List<Ingredients> ingredients;
    [SerializeField] private List<FoodItem> foodItems;
    [SerializeField] private List<Sauces> sauces;
    [SerializeField] private List<Drinks> drinks;

    //for loop
    public void CheckOrder()
    {
        foreach (FoodItem food in foodItems)
        {
            foreach (Ingredients ingredient in food.ingredients)
            {
                //check if ingredients are right
                //reference the ingredient ID's 
                foreach (var id in ingredient.ingredientID) 
                {
                    //compare to id of correct ingredients
                }
            }
        }
    }
}
