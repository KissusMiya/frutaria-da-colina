using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movimentaçãocliente : MonoBehaviour
{

    private GameObject Point;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        Point = GameObject.Find("point");
    }


    void Update()
    {
        agent.SetDestination(Point.transform.position);
    }
}
