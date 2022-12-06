using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class horas : MonoBehaviour
{
    public TMP_Text Horas;
    public TMP_Text Dias;
    float dayTime;
    int dayTimeGame;
    int dayCount;
    void Start()
    {
        dayTime = 0;
        dayTimeGame = 6;
        dayCount = 0;
    }

    void Update()
    {
        Horas.text = dayTimeGame.ToString("00");
        Dias.text = dayCount .ToString("Dia:0");

        dayTime += Time.deltaTime;
        if(dayTime >= 17)
        {
            if (dayTimeGame == 24)
            {
                dayTime = 6;
                dayCount++;
                dayTime = 0;
            }
            else
            {
            dayTimeGame++;
            dayTime = 0;
            }

        }
    }
}
