using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificarParaPlantar : MonoBehaviour
{
    [SerializeField]
    private List<string> sementes = new List<string>();

    [SerializeField]
    private string NomeDaSemente1;

    [SerializeField]
    private string NomeDaSemente2;

    void Start()
    {
  
    }

    public void Plantar()
    {
        if (temSemente(NomeDaSemente1))
        {

        }
        else if (temSemente(NomeDaSemente2))
        {

        }
    }
    public void AdicionaSemente(string nomeSemente)
    {
        sementes.Add(nomeSemente);
    }

    public bool temSemente(string nomeSemente) 
    {
        return sementes.Contains(nomeSemente);
    }
}
