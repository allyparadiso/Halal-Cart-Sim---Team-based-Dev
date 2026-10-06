using UnityEngine;

public class DragAndDrop : MonoBehaviour //put this script on all the ingredient container objects
{
    [SerializeField] private GameObject dragItemPrefab; //ingredient prefab you want to spawn in the container
    private GameObject currentDragObject;
    Vector3 mousePosition;
    public GameObject parentContainer; //target container
    public GameObject platingArea;

    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        transform.localRotation = Quaternion.Euler(90, 270, 0);
        mousePosition = Input.mousePosition - GetMousePos();
        Vector3 spawnPosition = parentContainer.transform.position;
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
        
    }

    //add dropped ingredients to list of added ingredients

}
