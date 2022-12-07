using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DialogoControle : MonoBehaviour
{
    public GameObject PainelDialogo;
    public GameObject resposta;

    public TextMeshProUGUI dialogo;

    private bool falaAtiva = false;

    Dialogo falas;
    [SerializeField]
    private menuInteracao __Iteragir;

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && falaAtiva)
        {
            if (falas.respostas.Length > 0)
            {
                MostraRespostas();
            }
            else
            {
                falaAtiva = false;
                PainelDialogo.SetActive(false);
                dialogo.gameObject.SetActive(false);
                __Iteragir.Resume();
            }
        }
    }

    void MostraRespostas()
    {
        //dialogo.gameObject.SetActive(false);
        falaAtiva = false;
        for (int i = 0; i < falas.respostas.Length; i ++)
        {
            GameObject tempResposta = Instantiate(resposta, PainelDialogo.transform) as GameObject;
            tempResposta.GetComponent<TextMeshProUGUI>().text = falas.respostas[i].resposta;
            tempResposta.GetComponent<BotaoResposta>().Setup(falas.respostas[i]);
        }
    }

    public void ProximaFala(Dialogo falar)
    {
        falas = falar;

        LimpaRespostas();

        falaAtiva = true;
        PainelDialogo.SetActive(true);
        dialogo.gameObject.SetActive(true); ;

        dialogo.text = falas.falar;
    }

    void LimpaRespostas()
    {
        BotaoResposta[] botaos = FindObjectsOfType<BotaoResposta>();
        foreach(BotaoResposta botao in botaos)
        {
            Destroy(botao.gameObject);
        }
    }
}                                                                                                                                                                
