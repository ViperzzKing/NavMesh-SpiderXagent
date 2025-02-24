using UnityEngine;

public class SlidingDoor : MonoBehaviour
{

    public Vector3 positionOffset = new Vector3(0f, -2f, 0f);
    private Vector3 openPosition;

    public float speed = 5f;

    void Start()
    {
        openPosition = transform.position + positionOffset;
    }

    public void OpenTheDoor()
    {
        transform.position = Vector3.MoveTowards(transform.position, openPosition, speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        //OpenTheDoor();
    }
}
