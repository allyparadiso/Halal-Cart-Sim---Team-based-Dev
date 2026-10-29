using System;
using UnityEngine;

public class FoodCombination : MonoBehaviour
{
    private SphereCollider foodCollider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foodCollider = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
