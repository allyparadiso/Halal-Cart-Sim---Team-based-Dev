using UnityEngine;
using UnityEngine.InputSystem;

//

public class CameraMovement : MonoBehaviour
{
    public Camera mainCamera;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) //rotates camera to the left in 90 degree increments
        {
            transform.Rotate(0f, -90f, 0f, Space.Self);
        }

        if (Input.GetKeyDown(KeyCode.D)) //rotates camera to the left in 90 degree increments
        {
            transform.Rotate(0f, 90f, 0f, Space.Self);
        }
    }
}
