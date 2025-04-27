using System.Runtime.CompilerServices;
using UnityEngine;

public class SelectObject : SimpleButton
{
    [SerializeField] private Vizualization vizualization;
    [SerializeField] private GameObject spawnObject;


    public override void OnClick()
    {
        base.OnClick();
        StartVizualization(spawnObject);
    }
    public void StartVizualization(GameObject vizualizationObject)
    {
        if(vizualization.currentObject != null)
        {
            vizualization.currentObject.SetActive(false);
            vizualization.currentObject = vizualizationObject;
            vizualization.currentObject.SetActive(true);
        }
        else
        {
            vizualization.currentObject = vizualizationObject;
            vizualization.currentObject.SetActive(true);
        }
    }

    private void Start()
    {
        AddButtonListener();
    }
}
