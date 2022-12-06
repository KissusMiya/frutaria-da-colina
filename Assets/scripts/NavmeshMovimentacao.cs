using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavmeshMovimentacao : MonoBehaviour
{
    public bool EstaInteragindo { get; set; }
    public GameObject Point;
    private NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
  
    }


    void Update()
    {
        agent.SetDestination(Point.transform.position);
      if (Input.GetButtonDown("interagir"))
        {
            EstaInteragindo = true;
        }
        else
        {
            EstaInteragindo = false;
        }
    }
    
}
