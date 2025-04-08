using UnityEngine;

public class SelectDetail : MonoBehaviour
{
    [SerializeField] private MoveDetail moveDetail;
    public bool isMove = true;
    public void Select()
    {
        moveDetail.currentDetail = gameObject;
    }
}
