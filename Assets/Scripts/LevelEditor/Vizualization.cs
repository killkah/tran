using UnityEngine;

public class Vizualization : MonoBehaviour
{
    public GameObject currentObject;

    public void VizuilizationTracking()
    {
        if(currentObject != null)
        {
            Vector3 mousePos = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(mousePos);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                if(hit.collider.tag == "Background")
                {
                    currentObject.transform.position = hit.point;
                }
            }
        }
        
    }
}
