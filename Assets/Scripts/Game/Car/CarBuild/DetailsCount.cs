using UnityEngine;

public class DetailsCount : MonoBehaviour
{
    public int count;

    private bool isVisible;

    [SerializeField] private GameObject startButton;

    private void Update()
    {
        if (!isVisible)
        {
            if (count == 4)
            {
                startButton.SetActive(true);
                isVisible = true;
            }
        }
    }
}
