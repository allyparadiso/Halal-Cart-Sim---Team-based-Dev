using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class RedragAndDrop : MonoBehaviour
{
    Vector3 mousePosition;
    public GameObject playerView;

    private GameObject currentDragObject;

    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void Update()
    {
        Vector3 playerRotation = playerView.transform.rotation.eulerAngles;

        Debug.Log(playerRotation);

        if (Mathf.Approximately(playerRotation.y, 90f))
        {
            transform.rotation = Quaternion.Euler(90, 270, 0);
        }

        if (Mathf.Approximately(playerRotation.y, 270f))
        {
            transform.rotation = Quaternion.Euler(90, 90, 0);
        }

        if (Mathf.Approximately(playerRotation.y, 0f) ||
            Mathf.Approximately(playerRotation.y, 360f))
        {
            transform.rotation = Quaternion.Euler(90, 180, 0);
        }

        if (Mathf.Approximately(playerRotation.y, 180f))
        {
            transform.rotation = Quaternion.Euler(90, 0, 0);
        }
    }

    private void OnMouseDown()
    {
        // Ensures that prefab matches rotation of the wall it's parented to.
        // JM: I'd like to change this so it matches the rotation of the camera.
        Debug.Log("Attempting to drag object.");
        mousePosition = Input.mousePosition - GetMousePos();

        currentDragObject = gameObject;
    }

    private void OnMouseDrag()
    {
        Vector3 dragPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
        currentDragObject.transform.position = dragPosition;
        Debug.DrawLine(Camera.main.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition));
    }
}
