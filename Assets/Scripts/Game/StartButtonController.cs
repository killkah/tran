using Unity.VisualScripting;
using UnityEngine;

public class StartButtonController : MonoBehaviour
{

    [SerializeField] private CarController carController;
    [SerializeField] private GameObject[] carModifiersButtons;
    [SerializeField] private DetailsCount detailsCount;
    [SerializeField] private GameObject detailsMenu;
    
    public void StartGame(GameObject button)
    {
        detailsMenu.SetActive(false);
        carController.isStarted = true;
        button.SetActive(false);
        for(int i = 0; i < carModifiersButtons.Length; i++)
        {
            carModifiersButtons[i].SetActive(true);
        }
    }
}
