using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Raymovement : MonoBehaviour
{
    public NavMeshAgent nAgent;
    public Transform point;
    // Start is called before the first frame update
    void Start()
    {
        nAgent.SetDestination(point.position);
    }

   // Update is called once per frame
   /* void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 m = Input.mousePosition;
            Ray r = Camera.main.ScreenPointToRay(m);
            RaycastHit hit;
            if (Physics.Raycast(r, out hit, Mathf.Infinity))
            {
                nAgent.SetDestination(hit.point);
            }
        }
    }*/
}
