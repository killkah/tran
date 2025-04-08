using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TipController : MonoBehaviour
{
    [SerializeField] private Text tip;
    private string textForChange;

    public void ChangeTip(string value)
    {
        textForChange = value;
        StartCoroutine("Timer");
    }

    public void ResetTip()
    {
        tip.text = "";
        StopCoroutine("Timer");
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(2);
        tip.text = textForChange;
    }
}
