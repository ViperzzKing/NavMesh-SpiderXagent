using UnityEngine;

public class CollectItems : MonoBehaviour
{

    public SlidingDoor door;
    public int collectedItems;
    public int requiredItems = 3;

    void Update()
    {
        if (collectedItems >= requiredItems)
        {
            door.OpenTheDoor();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectable")
        {

        collectedItems++;
        Destroy(other.gameObject);
        }
    }
}
