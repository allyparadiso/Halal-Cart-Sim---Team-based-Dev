using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    //[SerializeField] private LayerMask environment;
    [SerializeField] private LayerMask spawnLayer;
    [SerializeField] private LayerMask draggableLayers;

    private Collider currentObjectCollider;
    [SerializeField] private GameObject dragItemPrefab;
    private GameObject currentDragObject;
    private Camera mainCamera;
    //private bool isDragging = false;
    Vector3 mousePosition;

    public GameObject parentContainer;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        mousePosition = Input.mousePosition - GetMousePos();
        Vector3 spawnPosition = parentContainer.transform.position;
        if (spawnPosition != Vector3.zero)
        {
            currentDragObject = Instantiate(dragItemPrefab, spawnPosition, Quaternion.identity);

            currentObjectCollider = currentDragObject.GetComponentInChildren<Collider>();
            //isDragging = true;
        }
    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
        Vector3 dragPosition = GetMousePos();
        if (dragPosition != Vector3.zero)
        {
            currentDragObject.transform.position = dragPosition;
        }
        ;
    }

    /*private void OnMouseDown()
    {
        Vector3 spawnPosition = GetMouseWorldPos();
        if (spawnPosition != Vector3.zero)
        {
            currentDragObject = Instantiate(dragItemPrefab, spawnPosition, Quaternion.identity);

            currentObjectCollider = currentDragObject.GetComponentInChildren<Collider>();
            isDragging = true;
        }
    }

    private void Update()
    {
        Dragging();
    }

    private void Dragging()
    {

        if (isDragging && currentDragObject != null)
        {
            if (Input.GetMouseButton(0))
            {
                Vector3 dragPosition = GetMouseWorldPos();
                if (dragPosition != Vector3.zero)
                {
                    currentDragObject.transform.position = dragPosition;
                }
            }
        }

        else if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
            currentObjectCollider = null;
            currentDragObject = null;
        }
    }

    private Vector3 GetMouseWorldPos()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, draggableLayers))
        {
            return hit.point;
        }

        return Vector3.zero;
        
    }*/

    //add dropped ingredients to list of added ingredients
}
