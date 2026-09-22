using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovement : MonoBehaviour
{
    public Camera mainCamera;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            mainCamera.transform.rotation = Quaternion.Euler(0, -0, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            mainCamera.transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            mainCamera.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            mainCamera.transform.rotation = Quaternion.Euler(0, 90, 0);
        }
    }
}
