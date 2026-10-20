using System.Collections;
using UnityEngine;

public class FoodCooking : MonoBehaviour
{
    private SpriteRenderer foodSprite;

    public bool isCooking;

    public bool stateUncooked;
    public bool stateCooked;
    public bool stateOvercooked;
    public bool stateBurnt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foodSprite = GetComponent<SpriteRenderer>();
        isCooking = false;
        StartCoroutine(DoCooking());
    }

    // Update is called once per frame
    void Update()
    {
        if (stateUncooked)
        {

        }
        else if (stateCooked)
        {
            foodSprite.color = Color.red;
        }
    }

    private IEnumerator DoCooking()
    {
        while (isCooking)
        {
            stateCooked = true;
            yield return null;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Cooking started.");
        if(other.CompareTag("Grill"))
        {
            isCooking = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Grill"))
        {
            isCooking = false;
        }
    }
}
