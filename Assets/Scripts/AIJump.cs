using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIJump : MonoBehaviour
{
    //private NavMeshAgent navMeshAgent;
    

    //private float jumpForce = 700f;

    // Start is called before the first frame update
    void Start()
    {
        //navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    /*void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                SetAITargetLocation(hit.point);
            }
        }
    }

    private void SetAITargetLocation(Vector3 targetLocation)
    {
        navMeshAgent.SetDestination(targetLocation);
    }
    */

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"));
        {
            Destroy(gameObject);
        }
    }
    */
}