using UnityEngine;

public class CancelCreate : SimpleButton
{
    [SerializeField] private CreatedObjectsList createdObjects;

    public override void OnClick()
    {
        base.OnClick();
        Cancel();
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.LeftControl))
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Cancel();
            }
        }
    }

    public void Cancel()
    {
        if (createdObjects.createdObjects.Count > 0)
        {
            Destroy(createdObjects.createdObjects[createdObjects.createdObjects.Count - 1]);
        }
        
    }

}
