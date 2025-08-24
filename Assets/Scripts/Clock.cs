using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Day starts at 8am ends at 6pm

public class Clock : MonoBehaviour
{
    public TextMeshProUGUI ClockText;
    public int TimeHour = 8;
    public int TimeMinute;

    public void Start()
    {
        StartCoroutine(Clocktimer());
        ClockText.text = "08:00";
    }

    IEnumerator Clocktimer()
    {
        yield return new WaitForSecondsRealtime(2.5f);
        TimeMinute = TimeMinute + 5;

        if(TimeMinute == 60)
        {
            TimeHour++;
            TimeMinute = 0;
        }

        if (TimeHour == 9)
        {
            ClockText.text = "0" + TimeHour + ":" + TimeMinute;
        }

        if (TimeHour == 8)
        {
            ClockText.text = "0" + TimeHour + ":" + TimeMinute;
        }

        if (TimeMinute == 0)
        {
            ClockText.text =  TimeHour + ":0" + TimeMinute;
        }

        if (TimeMinute == 5)
        {
            ClockText.text = TimeHour + ":0" + TimeMinute;
        }

        if (TimeMinute == 5  && TimeHour == 8)
        {
            ClockText.text = "0" + TimeHour + ":0" + TimeMinute;
        }

        if (TimeMinute == 5 && TimeHour == 9)
        {
            ClockText.text = "0" + TimeHour + ":0" + TimeMinute;
        }

        if (TimeMinute == 0 && TimeHour == 8)
        {
            ClockText.text = "0" + TimeHour + ":0" + TimeMinute;
        }

        if (TimeMinute == 0 && TimeHour == 9)
        {
            ClockText.text = "0" + TimeHour + ":0" + TimeMinute;
        }

        if (TimeMinute > 6 && TimeHour > 9)
        {
            ClockText.text = TimeHour + ":" + TimeMinute;
        }

        if (TimeHour == 9 && TimeMinute > 9)
        {
            ClockText.text = "0" + TimeHour + ":" + TimeMinute;
        }

        if (TimeHour == 8 && TimeMinute > 9)
        {
            ClockText.text = "0" + TimeHour + ":" + TimeMinute;
        }

        if (TimeHour < 18)
        {
            StartCoroutine(Clocktimer());
        }

    }



}
