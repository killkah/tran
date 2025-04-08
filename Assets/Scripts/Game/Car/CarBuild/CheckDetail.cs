using UnityEngine;

public class CheckDetail : MonoBehaviour
{
    [SerializeField] private DetailsList detailsList;

    [SerializeField] private DetailsCount detailsCount;

    [SerializeField] private string detailCheckTag;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == detailCheckTag)
        {
            switch(collision.tag)
            {
                case "Fan":
                    detailsList.fan.SetActive(true);
                    Entry(collision);
                    break;
                case "Wings":
                    detailsList.wings.SetActive(true);
                    Entry(collision);
                    break;
                case "Rocket":
                    detailsList.rocket.SetActive(true);
                    Entry(collision);
                    break;
                case "FrontWheels":
                    detailsList.frontWheels.SetActive(true);
                    Entry(collision);
                    break;
                case "BehindWheels":
                    detailsList.behindWheels.SetActive(true);
                    Entry(collision);
                    break;
            }
        }
    }

    public void Entry(Collider2D value)
    {
        value.gameObject.SetActive(false);
        detailsCount.count++;
        gameObject.SetActive(false);
    }
}
