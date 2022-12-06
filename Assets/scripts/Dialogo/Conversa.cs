using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conversa : MonoBehaviour
{
    DialogoControle dialogocontrole;

    public Dialogo[] falas = new Dialogo [1];

    private bool dialogoConcluido = false;

    void Start()
    {
        dialogocontrole = FindObjectOfType<DialogoControle> ();
    }

    public void IniciarConversa()
    {
        if (!dialogoConcluido)
        {
            dialogocontrole.ProximaFala(falas[0]);
        }
       dialogoConcluido = true;
    }
}
