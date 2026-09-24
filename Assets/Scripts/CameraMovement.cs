using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovement : MonoBehaviour
{
    public Camera mainCamera;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) //rotate to front wall
        {
            mainCamera.transform.rotation = Quaternion.Euler(0, -0, 0);
        }
        if (Input.GetKeyDown(KeyCode.A)) //rotate to left wall
        {
            mainCamera.transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        if (Input.GetKeyDown(KeyCode.S)) //rotate to back wall
        {
            mainCamera.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKeyDown(KeyCode.D)) //rotate to right wall
        {
            mainCamera.transform.rotation = Quaternion.Euler(0, 90, 0);
        }
    }
}
