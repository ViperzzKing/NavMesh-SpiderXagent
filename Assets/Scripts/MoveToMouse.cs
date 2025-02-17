using UnityEngine;

public class MoveToMouse : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent agent;

    void Start()
    {
        // at start always get any componants your using
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitinfo;

        // doing the ray cast // getting the orgin // getting the direction // outputs the data
        //if we hit something this is true otherwise its false
        if (Physics.Raycast(ray.origin, ray.direction, out hitinfo))
        {
            agent.destination = hitinfo.point;
        }
    }
}
