using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

// Put this script on all the Ingredient Container Objects.

public class DragAndDrop : MonoBehaviour 
{
    public Plating platingScript;
    Vector3 spawnPosition;
    Vector3 mousePosition;

    [Header("Prefabs")]
    [SerializeField] private GameObject dragItemPrefab; //ingredient prefab you want to spawn in the container
    public GameObject parentContainer; //target container
    public GameObject playerView;
    public BoxCollider platingCollider;
    private GameObject currentDragObject;

    [Header("Walls")]
    public Transform frontWall;
    public Transform rightWall;
    public Transform backWall;
    public Transform leftWall;

    public bool inPlatingArea;

    private void Start()
    {
        spawnPosition = parentContainer.transform.position;
        platingScript = GetComponent<Plating>();
        inPlatingArea = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        inPlatingArea = true;
    }
    private void OnTriggerExit(Collider other)
    {
        inPlatingArea = false;
    }
    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        // Ensures that prefab matches rotation of the wall it's parented to.
        // JM: I'd like to change this so it matches the rotation of the camera.

        mousePosition = Input.mousePosition - GetMousePos();
        
        currentDragObject = Instantiate(dragItemPrefab, spawnPosition, transform.rotation);
    }

    private void OnMouseDrag()
    {
        Vector3 dragPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
        currentDragObject.transform.position = dragPosition;
        Debug.DrawLine(Camera.main.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition));
    }

    //private void OnMouseUp()
    //{
    //    if (inPlatingArea == false) // If let go when not within the plating area collider, it sends it back to the spawn point and destroys the object.
    //    {
    //        currentDragObject.transform.position = spawnPosition;
    //        DestroyIngredient();
    //    }
    //    else if (inPlatingArea == true) // If let go within the collider, add object to list of added ingredients
    //    {
    //        platingScript.Instance.AddIngredient(currentDragObject.GetComponent<Ingredients>()); // Currently doesn't work.
    //    }
    //}

    public void DestroyIngredient()
    {
        Destroy(currentDragObject);
    }

}
