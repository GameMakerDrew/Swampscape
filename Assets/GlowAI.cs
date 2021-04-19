using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GlowAI : MonoBehaviour
{

    private Transform player;
    private NavMeshAgent agent;

    private bool inSight;

    float sightRange = 10f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("FirstPersonPlayer").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        inSight = Physics.CheckSphere(transform.position, sightRange);
        if (inSight)
        {
            agent.SetDestination(player.position);
        }
    }

    private void Patrol()
    {

    }
}
