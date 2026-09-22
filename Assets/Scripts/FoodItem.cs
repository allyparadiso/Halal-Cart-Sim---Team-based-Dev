using UnityEngine;

[CreateAssetMenu(fileName = "NewFoodItem", menuName = "New Food Item")] //right-click in the project section, click create, then click food item to add new food type
public class FoodItem : ScriptableObject
{
    public string itemName;
    public float price;
    public Sprite itemIcon;
}
