using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

//controls the money


public class Money : MonoBehaviour
{
    public Money Instance;
    public float money;
    private Customer customerScript;
    FoodItem currentFood;
    private float foodPrice;
    private float originalPercent = 100f;
    private float percentagePenalty = 5f;
    private void Start()
    {
        if (Instance == null) Instance = this;
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

    public void AddMoney(float moneyToAdd)
    {
        moneyToAdd = foodPrice;
        money += moneyToAdd;
        //need to add the drink price too
    }

    public void SubtractMoney(float moneyToSubtract)
    {
        moneyToSubtract = originalPercent * (1f - (percentagePenalty / 100f));
        money += foodPrice - moneyToSubtract;
    }
}
