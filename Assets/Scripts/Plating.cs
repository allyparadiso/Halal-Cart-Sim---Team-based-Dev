using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.Linq;

//

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
    public void GetCurrentOrder()
    {
        currentFoodOrder = GetComponent<Customer>().currentOrder;
        currentSauceOrder = GetComponent<Customer>().currentSauce;
    }
    public void AddIngredient(Ingredients ingredient)
    {
        ingredientsAdded.Add(ingredient);
    }

    public bool IsRecipeComplete(FoodItem recipe, List<Ingredients> ingredientsAdded)
    {
        recipe = currentFoodOrder;
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
