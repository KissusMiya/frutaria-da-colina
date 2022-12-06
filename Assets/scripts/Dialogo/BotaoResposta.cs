using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoResposta : MonoBehaviour
{
    Resposta respostaData;

    public void ProximaFala()
    {
        FindObjectOfType<DialogoControle>().ProximaFala(respostaData.proximaFala);
    }
    
    public void Setup(Resposta resposta)
    {
     respostaData = resposta;
    }
}
