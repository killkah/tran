using UnityEngine;

public class MoveDetail : MonoBehaviour
{
    public GameObject currentDetail;

    public void Move()
    {
        if(currentDetail.GetComponent<SelectDetail>().isMove == true)
        {
            Vector3 mousePos = Input.mousePosition;
            currentDetail.transform.position = mousePos;
        }
    }
}
