
using UnityEngine;
using UnityEngine.EventSystems;

public class BuildObject : MonoBehaviour
{
    [SerializeField] private Vizualization vizualization;
    [SerializeField] private GameObject[] objects;
    [SerializeField] private CreatedObjectsList createdObjectsList;

    private void Update()
    {
        if(vizualization.currentObject != null)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Create();
            }
        }
    }

    public void Create()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        for (int i = 0; i < objects.Length -1; i++)
        {
            if (vizualization.currentObject.name == objects[i].name)
            {
                GameObject newObject = Instantiate(objects[i], vizualization.currentObject.transform.position, Quaternion.identity);
                createdObjectsList.createdObjects.Add(newObject);
            }
        }
    }
}
