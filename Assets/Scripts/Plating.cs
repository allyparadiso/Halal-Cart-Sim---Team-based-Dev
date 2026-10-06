using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Plating : MonoBehaviour
{
    public List<Ingredients> ingredients;
    private List<Ingredients> addedIngredients = new List<Ingredients>();
    private Collider platingCollider;
}
