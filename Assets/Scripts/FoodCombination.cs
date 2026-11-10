using System.Collections.Generic;
using UnityEngine;

public class FoodCombination : MonoBehaviour
{
    private SphereCollider foodCollider;

    public LayerMask ingredientLayer;
    public List<Ingredients> ingredients = new List<Ingredients>();
    public List<GameObject> menuItems;

    public float detectionRadius = 5f;

    void Start()
    {
        foodCollider = GetComponent<SphereCollider>();
    }

    void Update()
    {
        CombinationCheck();
    }

    private void CombinationCheck()
    {
        // Detect ingredients within the radius
        Collider[] detectedIngredients = Physics.OverlapSphere(transform.position, detectionRadius, ingredientLayer);

        foreach (Collider detected in detectedIngredients)
        {
            // Get the IngredientIdentifier component
            IngredientIdentifier identifier =
                detected.GetComponent<IngredientIdentifier>();

            if (identifier == null)
                continue;
            Ingredients ingredient = identifier.ingredientSO;

            if (ingredient == null)
                continue;

            // Check if the ingredient exists in our ingredients list
            if (ingredients.Contains(ingredient))
            {
                // Check the GameObject's tag
                switch (detected.tag)
                {
                    case "Chicken":
                        Debug.Log("Chicken detected!");

                        Instantiate(menuItems[0], transform.position, Quaternion.identity);
                        Destroy(detected.gameObject);
                        Destroy(gameObject);

                        break;

                    case "Lamb":
                        Debug.Log("Lamb detected!");

                        Instantiate(menuItems[1], transform.position, Quaternion.identity);
                        Destroy(detected.gameObject);
                        Destroy(gameObject);

                        break;
                }
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, detectionRadius);
    }
}
