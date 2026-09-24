using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    Transform objectParent;

    public float minDropDistance = 2f;
    public float maxDropDistance = 3f;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {

            }
        }
    }
}
