using UnityEngine;
using System.Collections.Generic;

public class Customer : MonoBehaviour
{
    public List<FoodItem> availableMenu; //list of possible orders
    public FoodItem currentOrder; //NPC's current order

    private void Start() //change this to a method that triggers after npc walks up to window
    {
        ChooseRandomFood();
    }

    public void ChooseRandomFood()
    {
        if (availableMenu.Count > 0)
        {
            int index = Random.Range(0, availableMenu.Count); //generates random number between 0 and the number of food items available
            currentOrder = availableMenu[index];
            Debug.Log($"{gameObject.name} ordered: {currentOrder.itemName}");
        }
    }
}
