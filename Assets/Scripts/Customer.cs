using UnityEngine;
using System.Collections.Generic;

// Logic for how the customers behave.

public class Customer : MonoBehaviour
{
    public Customer Instance;
    public List<FoodItem> availableMenu; // List of possible orders.
    public FoodItem currentOrder; // NPC's current order.
    public List<Sauces> availableSauces;
    public Sauces currentSauce;
    public List<Sauces> wantedSauces; // For if / when we add option for multiple sauces.

    // JM: They're saying to turn the Start function into something that repeats, initiating once they're the customer we're serving.
    private void Start() // Change this to a method that triggers after NPC walks up to window. 
    {
        if (Instance == null) Instance = this;
        ChooseRandomFood();
        ChooseRandomSauce();
    }

    public void ChooseRandomFood()
    {
        Debug.Log(availableMenu.Count);

        if (availableMenu.Count > 0)
        {
            int index = Random.Range(0, availableMenu.Count); // Generates random number between 0 and the number of food items available.
            currentOrder = availableMenu[index]; // Assigns a menu item from the avaliable menu to the order the customer wants.
            Debug.Log($"{gameObject.name} ordered: {currentOrder.foodName}");
        }
    }

    public void ChooseRandomSauce()
    {
        Debug.Log(availableSauces.Count);

        if (availableSauces.Count > 0)
        {
            int index = Random.Range(0, availableSauces.Count); // Generates random number between 0 and the number of sauces available.
            currentSauce = availableSauces[index]; // Assigns a sauce from the avaliable sauces to the sauce the customer wants.
            Debug.Log($"{gameObject.name} ordered: {currentSauce.sauceName}");
        }
    }

    // Grabs the assigned order in ChooseRandomFood() and assigns that as what the player must serve the customer.
    public FoodItem GetActiveFood()
    {
        return currentOrder;
    }

    // Grabs the assigned order in ChooseRandomSauce() and assigns that as what the player must serve the customer.
    public Sauces GetActiveSauce()
    {
        return currentSauce;
    }
}
