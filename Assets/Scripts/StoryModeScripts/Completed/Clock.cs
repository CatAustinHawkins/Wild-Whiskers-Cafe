using System.Collections;
using TMPro;
using UnityEngine;

//Day starts at 8am ends at 6pm
//Used in Story Mode to control the clock

public class Clock : MonoBehaviour
{
    public TextMeshProUGUI ClockText;
    public int TimeHour = 8;
    public int TimeMinute = 0;

    public bool DayComplete;

    private void Start()
    {
        UpdateClockText(); // show initial time
        StartCoroutine(ClockTimer());
    }

    IEnumerator ClockTimer()
    {
        while (TimeHour < 18) // run until 6pm
        {
            yield return new WaitForSecondsRealtime(2.5f);

            // Advance time by 5 minutes
            TimeMinute += 5;

            if (TimeMinute >= 60)
            {
                TimeMinute = 0;
                TimeHour++;
            }

            UpdateClockText();
        }

        // Day is over when it hits 18:00
        EndDay();
    }

    private void UpdateClockText()
    {
        // Format: always 2 digits for hours/minutes (08:05, 13:00, etc.)
        ClockText.text = $"{TimeHour:D2}:{TimeMinute:D2}";
    }

    public void EndDay()
    {
        Debug.Log("Day ended at 18:00");
        DayComplete = true; //for other scripts to read
    }
}
