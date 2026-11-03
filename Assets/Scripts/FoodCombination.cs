using System;
using System.Collections.Generic;
using UnityEngine;

public class FoodCombination : MonoBehaviour
{
    private SphereCollider foodCollider;
    public LayerMask ingredientLayer;
    public List<Ingredients> ingredients;
    public List<GameObject> menuItems;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foodCollider = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    //private void CombinationCheck()
    //{
    //    if(this.name == "Rice")
    //    {
    //        Collider[] riceCollider = Physics.OverlapSphere(this.transform.position, 5, ingredientLayer);
    //    }
    //}

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Chicken"))
        {
            //Instantiate(menuItems.Count, other.transform, );
        }
    }

}
