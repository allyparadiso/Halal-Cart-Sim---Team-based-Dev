using UnityEngine;
using System.Collections.Generic;

public class Customer : MonoBehaviour
{
    public List<FoodItem> availableMenu; //list of possible orders
    public FoodItem currentOrder; //NPC's current order
    public List<Sauces> availableSauces;
    public Sauces currentSauce;
    public List<Sauces> wantedSauces; //for if / when we add option for multiple sauces

    private void Start() //change this to a method that triggers after npc walks up to window
    {
        ChooseRandomFood();
        ChooseRandomSauce();
    }

    public void ChooseRandomFood()
    {
        if (availableMenu.Count > 0)
        {
            int index = Random.Range(0, availableMenu.Count); //generates random number between 0 and the number of food items available
            currentOrder = availableMenu[index];
            Debug.Log($"{gameObject.name} ordered: {currentOrder.foodName}");
        }
    }

    public void ChooseRandomSauce()
    {
        if (availableSauces.Count > 0)
        {
            int index = Random.Range(0, availableSauces.Count); //generates random number between 0 and the number of sauces available
            currentSauce = availableSauces[index];
            Debug.Log($"{gameObject.name} ordered: {currentSauce.sauceName}");
        }
    }
}
