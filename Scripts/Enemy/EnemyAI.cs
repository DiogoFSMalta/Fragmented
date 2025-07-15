using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    NavMeshAgent agent;
    GameObject[] goals;

    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        goals = GameObject.FindGameObjectsWithTag("goals");
        int i = Random.RandomRange(0, goals.Length);
        agent.SetDestination(goals[i].transform.position);
        float sm = Random.Range(2f, 5f);
        agent.speed *= sm;
    }

    // Update is called once per frame
    void Update()
    {
        if(agent.remainingDistance < 1)
        {
            int i = Random.RandomRange(0, goals.Length);
            agent.SetDestination(goals[i].transform.position);
        }
    }
}
