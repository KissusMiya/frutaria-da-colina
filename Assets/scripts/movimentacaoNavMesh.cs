using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class movimentacaoNavMesh : MonoBehaviour
{
    public GameObject BotaoEsquerdo;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        BotaoEsquerdo = GameObject.Find("Point");
    }


    void Update()
    {
        agent.SetDestination(BotaoEsquerdo.transform.position);
    }
}
