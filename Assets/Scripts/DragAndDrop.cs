using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    [SerializeField] private GameObject dragItemPrefab;
    private GameObject currentDragObject;
    Vector3 mousePosition;
    public GameObject parentContainer;

    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        mousePosition = Input.mousePosition - GetMousePos();
        Vector3 spawnPosition = parentContainer.transform.position;
        currentDragObject = Instantiate(dragItemPrefab, spawnPosition, Quaternion.identity);
        //Debug.Break();
    }

    private void OnMouseDrag()
    {
        Vector3 dragPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
        currentDragObject.transform.position = dragPosition;
        Debug.DrawLine(Camera.main.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition));
    }

    //add dropped ingredients to list of added ingredients

}
