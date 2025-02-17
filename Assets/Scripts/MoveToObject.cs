using UnityEngine;
using UnityEngine.AI;

public class MoveToObject : MonoBehaviour
{

    public GameObject moveToObject;

    //our component were using
    private NavMeshAgent agent;

   
    void Start()
    {
        // at start always get any componants your using
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( agent != null && moveToObject != null )
        {
            agent.destination = moveToObject.transform.position;
        }
    }
}
