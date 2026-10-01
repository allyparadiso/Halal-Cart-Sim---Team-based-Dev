using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    //timer
    //check if order is correct
    [SerializeField] private List<Ingredients> ingredients;
    [SerializeField] private List<FoodItem> foodItems;
    [SerializeField] private List<Sauces> sauces;
    [SerializeField] private List<Drinks> drinks;
    //[SerializeField] private List<AddedIngredients>;
    

    private void Awake()
    {
        instance = this;
    }

    //public bool HasCorrectIngredients(FoodItem targetFood, List<AddedIngredients>)

    //for loop
    /*public void CheckOrder()
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
    }*/
}
