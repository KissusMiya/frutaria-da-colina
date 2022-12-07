using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class interacao : MonoBehaviour
{
    [SerializeField]
    private NavmeshMovimentacao __interagindo;

    [SerializeField]
    private botaoesquerdo __Besquerdo;

    [SerializeField]
    private botaodireito __Bdireito;

    [SerializeField]
    private menuInteracao __JanelaInteracao;


    public LayerMask PlayerLayer;
    public float tamanhoX;
    public float tamanhoY;
    public float eixoX;

    public Camera cam;
    public GameObject BotaoD;
    public GameObject BotaoE;

    private void FixedUpdate()
    {
        Interacao();
    }

    private void Interacao()
    {
        Collider2D hit = Physics2D.OverlapBox(gameObject.transform.position + new Vector3(0,eixoX,0), new Vector2(tamanhoY, tamanhoX), (tamanhoY + tamanhoY) / 2, PlayerLayer);

 
            if (__Bdireito.BDireitoInteragir == true)
            {
                if (__Besquerdo.BEsquerdoInteragir == true)
                {
                    if (hit != null)
                    {
                        if (__interagindo.EstaInteragindo == true)
                        {
                           __JanelaInteracao.ChamaMenu();
                        }
                    }
                }
                else
                {
                    Vector3 BotaoD = cam.ScreenToWorldPoint(Input.mousePosition);
                    BotaoE.transform.position = new Vector3(BotaoD.x, BotaoD.y, transform.position.z);
                }
            }



    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position + new Vector3(0,eixoX,0), new Vector3(tamanhoY, tamanhoX));
    }
}
