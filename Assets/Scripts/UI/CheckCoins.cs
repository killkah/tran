using UnityEngine;
using UnityEngine.UI;

public class CheckCoins : MonoBehaviour
{
    [SerializeField] private CoinsDataScript coinsData;
    [SerializeField] private int cost;

    private void Update()
    {
        if(coinsData.coins >= cost)
        {
            gameObject.GetComponent<Text>().color = Color.white;
        }
        else
        {
            gameObject.GetComponent<Text>().color = Color.red;
        }
    }
}
