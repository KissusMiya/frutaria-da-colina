using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorCliente : MonoBehaviour
{
    public GameObject[] clientes;

    public Transform geradorcliente;

    public float tempoMaximoGerar;
    public float tempoAtula;

    int numeroAleatorio;
    
    private void Start()
    {
        tempoAtula = tempoMaximoGerar;
    }
    void Update()
    {
        tempoAtula -= Time.deltaTime;

        if (tempoAtula <= 0)
        {
            GerarCliente();
        }
    }

    private void GerarCliente()
    {
        numeroAleatorio = Random.Range(0, 2);

        Instantiate(clientes[numeroAleatorio], geradorcliente.position, Quaternion.Euler(0f, 0f, 0f));

        tempoAtula = tempoMaximoGerar;
    }
}
