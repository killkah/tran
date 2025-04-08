using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class PurchaseButton : SimpleButton
{

    [SerializeField] private GameObject purchaseMenu;

    [SerializeField] private int coinsCount;

    [SerializeField] private CoinsDataScript coinsData;
    public override void OnClick()
    {
        base.OnClick();
        StartCoroutine("Purchase");
    }

    private void Start()
    {
        AddButtonListener();
    }

    IEnumerator Purchase()
    {
        purchaseMenu.SetActive(true);
        yield return new WaitForSeconds(3);
        coinsData.coins += coinsCount;
        purchaseMenu.SetActive(false);
    }
}
