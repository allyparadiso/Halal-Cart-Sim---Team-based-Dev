using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

//

public class DragAndDrop : MonoBehaviour //put this script on all the ingredient container objects
{
    public Plating platingScript;
    Vector3 spawnPosition;
    Vector3 mousePosition;

    [Header("Prefabs")]
    [SerializeField] private GameObject dragItemPrefab; //ingredient prefab you want to spawn in the container
    public GameObject parentContainer; //target container
    public BoxCollider platingCollider;
    private GameObject currentDragObject;

    [Header("Walls")]
    public Transform frontWall;
    public Transform rightWall;
    public Transform backWall;
    public Transform leftWall;

    private bool inPlatingArea;

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
        if (parentContainer.transform.IsChildOf(rightWall))
        {
            transform.localRotation = Quaternion.Euler(90, 270, 0); //the specific rotation needed for the object on the right wall to be facing the camera
        } 
        if (parentContainer.transform.IsChildOf(leftWall))
        {
            transform.localRotation = Quaternion.Euler(90, 90, 0); //the specific rotation needed for the object on the left wall to be facing the camera
        }
        if (parentContainer.transform.IsChildOf(frontWall))
        {
            transform.localRotation = Quaternion.Euler(90, 180, 0); //the specific rotation needed for the object on the front wall to be facing the camera
        }
        if (parentContainer.transform.IsChildOf(backWall))
        {
            transform.localRotation = Quaternion.Euler(90, 0, 0); //the specific rotation needed for the object on the back wall to be facing the camera
        }

        mousePosition = Input.mousePosition - GetMousePos();
        
        currentDragObject = Instantiate(dragItemPrefab, spawnPosition, transform.rotation);
    }

    private void OnMouseDrag()
    {
        Vector3 dragPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
        currentDragObject.transform.position = dragPosition;
        Debug.DrawLine(Camera.main.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition));
    }

    private void OnMouseUp()
    {
        if (inPlatingArea == false) //if let go when not within the plating area collider, it sends it back to the spawn point and destroys the object
        {
            currentDragObject.transform.position = spawnPosition;
        }
        else //if let go within the collider, add object to list of added ingredients
        {
            platingScript.Instance.AddIngredient(currentDragObject.GetComponent<Ingredients>()); //currently doesnt work
        }
        
        //DestroyIngredient();
    }

    public void DestroyIngredient()
    {
        Destroy(currentDragObject);
    }

}
