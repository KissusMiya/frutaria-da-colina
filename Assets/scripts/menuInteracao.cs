using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class menuInteracao : MonoBehaviour
{
    [SerializeField]
    private Crop __IniciarAporo;

    [SerializeField]
    private Crop1 __IniciarKomato;

    [SerializeField]
    private Conversa __iniciarDialogo;

    public static bool PauseGame;

    public Camera cam;

    public GameObject InteracaoMenuUI;
    public GameObject BotaoD;

    
    public void ChamaMenu()
    {
        if (PauseGame)
        {
            Resume();
        }
        else
        {
            Pause();
        }
        Vector3 BotaoD = cam.ScreenToWorldPoint(Input.mousePosition);
        InteracaoMenuUI.transform.position = new Vector3(BotaoD.x, BotaoD.y, transform.position.z);
    }

    public void Resume()
    {
        InteracaoMenuUI.SetActive(false);
        Time.timeScale = 1f;
        PauseGame = false;
    }

    public void Pause()
    {
        InteracaoMenuUI.SetActive(true);
        Time.timeScale = 0f;
        PauseGame = true;
    }

    public void platarAporo()
    {
        __IniciarAporo.Iniciar();
    }

    public void platarKomato()
    {
        __IniciarKomato.Iniciar();
    }


    public void Colher()
    {
        Debug.Log("Colhendo...");
    }
    public void Dormir()
    {
        Debug.Log("Dormindo...");
    }
    public void ChutaACama()
    {
        Debug.Log("Chutou a cama");
    }
    
    public void Xigar()
    {
        Debug.Log("vai toma no olho do cu");
    }
    public void Conversar()
    {
        __iniciarDialogo.IniciarConversa();
    }
}
