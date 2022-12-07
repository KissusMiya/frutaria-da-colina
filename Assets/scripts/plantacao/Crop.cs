using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(SpriteRenderer))]
public class Crop : MonoBehaviour
{
    public int Aporo;
    public TMP_Text scoreAporo;
    public CropSO crop;
    private SpriteRenderer _renderer;

    public  void Iniciar()
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
            Aporo = Aporo + 2;
            scoreAporo.text = Aporo.ToString("0");
        }
    }

    void Update()
    {
        
    }
}
