using UnityEngine;
using UnityEngine.UI;

public class PrintCoinsUI : MonoBehaviour
{
    [SerializeField] private CoinsDataScript coinsData;
    private void Update()
    {
        if(coinsData.coins >= 1000)
        {
            float coins = coinsData.coins / 1000f;
            gameObject.GetComponent<Text>().text = $"{coins}K";
        }
        else
        {
            gameObject.GetComponent<Text>().text = coinsData.coins.ToString();
        }
        
    }
}
