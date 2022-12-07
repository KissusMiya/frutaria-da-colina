using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(SpriteRenderer))]
public class Crop1 : MonoBehaviour
{
    public int Komato = 0;
    public TMP_Text scoreKomato;
    public CropSO crop;
    private SpriteRenderer _renderer;

    public void Iniciar()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _renderer.sprite = crop.cropsSprites[crop.stage];
    }
    public void Envolve()
    {
        if (crop.stage < 5)
        {
            crop.stage++;
            _renderer.sprite = crop.cropsSprites[crop.stage];
        }
    }

    public void CropTime()
    {
        if (crop.stage == 5)
        {
            Debug.Log("Its Science, Bitch!");
            Komato = Komato ++;
            scoreKomato.text = Komato.ToString("0");
                
        }
    }

    void Update()
    {
        
    }
}
