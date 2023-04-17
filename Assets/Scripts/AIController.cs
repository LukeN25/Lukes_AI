using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    /*
    private NavMeshAgent navMeshAgent;
    public Transform otherPlayer;

    public float timer, wanderTime;

    public enum State
    {
        FindCharacter,
        //Wander,
        //Idle
    }

    private State currentState;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        currentState = State.FindCharacter;
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case State.FindCharacter:

                SetAITargetLocation(otherPlayer.position);

                /*if(navMeshAgent.remainingDistance < 1f && navMeshAgent.remainingDistance > 0.5f)
                {
                    currentState = State.Wander;
                }
                

                break;

           /* case State.Wander:

                timer += Time.deltaTime;

                Wander();

                break;

            case State.Idle:

                break;
           
        }
        
    }

    private void SetAITargetLocation(Vector3 targetLocation)
    {
        navMeshAgent.SetDestination(targetLocation);
    }

    /*private void Wander()
    {
        if (timer >= wanderTime)
        {
            Vector2 wanderTarget = Random.insideUnitCircle * wanderTime;
            Vector3 wanderPos3D = new Vector3(transform.position.x + wanderTarget.x, transform.position.y, transform.position.z + wanderTarget.y);
            SetAITargetLocation(wanderPos3D);
            timer = 0;
        }
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) ;
        {
            Destroy(gameObject);
        }
    }
    */
}
