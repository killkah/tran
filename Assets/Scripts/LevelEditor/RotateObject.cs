using UnityEngine;

public class RotateObject : SimpleButton
{
    [SerializeField] private CreatedObjectsList createdObjectsList;

    public override void OnClick()
    {
        base.OnClick();
        Rotate();
    }

    private void Update()
    {
        if (createdObjectsList != null)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Rotate();
            }
        }
    }
    public void Rotate()
    {
        if(createdObjectsList.createdObjects.Count > 0)
        {
            createdObjectsList.createdObjects[createdObjectsList.createdObjects.Count - 1].transform.Rotate(90, 0, 0);
        }
        
    }

    private void Start()
    {
        AddButtonListener();
    }
}
