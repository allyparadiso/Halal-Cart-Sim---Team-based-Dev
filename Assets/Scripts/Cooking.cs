using UnityEngine;

// JM: Fully unfinished script, used for the cooking system.

// Timer for time cooked.
// Grill behavior.

public class Cooking : MonoBehaviour
{
    [Header("Food State")]
    public bool foodUncooked;
    public bool foodCooked;
    public bool foodOvercooked;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Grill"))
        {
            Debug.Log("Entered Grilling Area.");
            foodCooked = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Grill"))
        {
            Debug.Log("Exited Grilling Area.");
            foodCooked = true;
        }
    }
}
