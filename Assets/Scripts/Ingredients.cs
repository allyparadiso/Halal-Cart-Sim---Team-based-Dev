using UnityEngine;

[CreateAssetMenu(fileName = "NewIngredient", menuName = "Ingredient")]
public class Ingredients : ScriptableObject
{
    public string ingredientName;
    public Sprite ingredientIcon;
}
