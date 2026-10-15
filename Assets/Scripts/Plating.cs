using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.Linq;

// JM: Another question would be "Q: What is each panel supposed to do? I understand the front panel and right panel kinda, but what about the back and left panel?"

public class Plating : MonoBehaviour
{
    public Plating Instance;
    private Money moneyScript;
    private Customer customer;
    private FoodItem currentFoodOrder;
    private Sauces currentSauceOrder;
    public List<Ingredients> ingredientsAdded = new List<Ingredients>();

    private void Start()
    {
        if (Instance == null) Instance = this;

        customer = GetComponent<Customer>();
        moneyScript = GetComponent<Money>();
    }

    // Grabs the customers current order and current sauce.
    public void GetCurrentOrder()
    {
        currentFoodOrder = GetComponent<Customer>().currentOrder;
        currentSauceOrder = GetComponent<Customer>().currentSauce;
    }

    // JM: Don't really understand why we need this?
    public void AddIngredient(Ingredients ingredient)
    {
        ingredientsAdded.Add(ingredient);
    }

    // 
    public bool IsRecipeComplete(FoodItem recipe, List<Ingredients> ingredientsAdded)
    {
        recipe = currentFoodOrder;

        // Checks the food order for the required items, and deducts points based on if we serve too little.
        foreach (var requiredItem in recipe.neededIngredients)
        {
            int requiredCount = recipe.neededIngredients.Count;
            int amountAdded = ingredientsAdded.Count;

            if (amountAdded < requiredCount)
            {
                return false;
                moneyScript.Instance.SubtractMoney(recipe.price);
            }
        }
        return true;
    }
}
