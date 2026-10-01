using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public int money;
    private Customer customerScript;
    FoodItem currentFood;
    private float foodPrice;
    private void Start()
    {
        money = 0;

    }
    public void GetActiveOrderItems()
    {
        currentFood = customerScript.GetActiveFood();
        if (currentFood != null)
        {
            foodPrice = currentFood.price;
        }
    }

    private void Update()
    {
        GetActiveOrderItems();
    }

    public void AddMoney(int moneyToAdd)
    {

        //add all prices of items to get moneyToAdd
        // if order is incorrect, money += moneyToAdd - (whatever func that can calculate 5% of moneyToAdd and subract it from total moneyToAdd)
        // else:
        money += moneyToAdd;
    }

    public void SubtractMoney(int moneyToSubtract)
    {
        
    }
}
