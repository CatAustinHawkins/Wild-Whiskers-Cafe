using System.Collections;
using UnityEngine;

public class CustomerSpawning : MonoBehaviour
{
    public int Randomint;
    public int PrevRandomint;

    public Transform CustomerSpawn;

    public GameObject[] Animals;

    public GameObject DayCheckGO;
    public DayCheck DayCheckScript;

    //stop spawning after 300 seconds, at the end of the day

    //animals that can spawn depend on the day

    public void Start()
    {
        DaySwitch();

        Debug.Log(DayCheckScript.Day);
    }

    public void DaySwitch()
    {
        switch(DayCheckScript.Day)
        {
            case 1:
                SpawnAnimalDay1();
                return;
            case 2:
                SpawnAnimalDay2();
                return;
            case 3:
                SpawnAnimalDay3();
                return;
            case 4:
                SpawnAnimalDay4();
                return;
            case 5:
                SpawnAnimalDay5();
                return;
            case 6:
                SpawnAnimalDay6();
                return;
            case 7:
                SpawnAnimalDay7();
                return;
            case 8:
                SpawnAnimalDay8();
                return;
            case 9:
                SpawnAnimalDay9();
                return;
            case 10:
                SpawnAnimalDay10();
                return;
            case 11:
                SpawnAnimalDay11();
                return;
            case 12:
                SpawnAnimalDay12();
                return;
            case 13:
                SpawnAnimalDay13();
                return;
            case 14:
                SpawnAnimalDay14();
                return;
            case 15:
                SpawnAnimalDay15();
                return;
            case 16:
                SpawnAnimalDay16();
                return;
            case 17:
                SpawnAnimalDay17();
                return;
            case 18:
                SpawnAnimalDay18();
                return;
            case 19:
                SpawnAnimalDay19();
                return;
            case 20:
                SpawnAnimalDay20();
                return;
            case 21:
                SpawnAnimalDay21();
                return;
            case 22:
                SpawnAnimalDay22();
                return;
        }
    }

    public void SpawnAnimalDay1()
    {
        Instantiate(Animals[0], CustomerSpawn);
        StartCoroutine(Clocktimer());
    }

    public void SpawnAnimalDay2()
    {
        Randomint = Random.Range(0, 2);

        if(Randomint == PrevRandomint)
        {
            Randomint = Random.Range(0, 2);
        }

        PrevRandomint = Randomint;

        Instantiate(Animals[Randomint], CustomerSpawn);
        StartCoroutine(Clocktimer());
    }

    public void SpawnAnimalDay3()
    {
        Randomint = Random.Range(0, 3);

        if (Randomint == PrevRandomint)
        {
            Randomint = Random.Range(0, 3);
        }

        PrevRandomint = Randomint;

        Instantiate(Animals[Randomint], CustomerSpawn);
        StartCoroutine(Clocktimer());
    }

    public void SpawnAnimalDay4()
    {
        Randomint = Random.Range(0, 4);

        if (Randomint == PrevRandomint)
        {
            Randomint = Random.Range(0, 4);
        }

        PrevRandomint = Randomint;

        Instantiate(Animals[Randomint], CustomerSpawn);
        StartCoroutine(Clocktimer());
    }

    public void SpawnAnimalDay5()
    {
        Randomint = Random.Range(0, 5);

        if (Randomint == PrevRandomint)
        {
            Randomint = Random.Range(0, 5);
        }

        PrevRandomint = Randomint;

        Instantiate(Animals[Randomint], CustomerSpawn);
        StartCoroutine(Clocktimer());
    }

    public void SpawnAnimalDay6()
    {
        Randomint = Random.Range(0, 6);

        if (Randomint == PrevRandomint)
        {
            Randomint = Random.Range(0, 6);
        }

        PrevRandomint = Randomint;

        Instantiate(Animals[Randomint], CustomerSpawn);
        StartCoroutine(Clocktimer());
    }

    public void SpawnAnimalDay7()
    {
        Randomint = Random.Range(0, 7);

        if (Randomint == PrevRandomint)
        {
            Randomint = Random.Range(0, 7);
        }

        PrevRandomint = Randomint;

        Instantiate(Animals[Randomint], CustomerSpawn);
        StartCoroutine(Clocktimer());
    }

    public void SpawnAnimalDay8()
    {
        Randomint = Random.Range(0, 8);

        if (Randomint == PrevRandomint)
        {
            Randomint = Random.Range(0, 8);
        }

        PrevRandomint = Randomint;

        Instantiate(Animals[Randomint], CustomerSpawn);
        StartCoroutine(Clocktimer());
    }

    public void SpawnAnimalDay9()
    {
        Randomint = Random.Range(0, 9);

        if (Randomint == PrevRandomint)
        {
            Randomint = Random.Range(0, 9);
        }

        PrevRandomint = Randomint;

        Instantiate(Animals[Randomint], CustomerSpawn);
        StartCoroutine(Clocktimer());
    }

    public void SpawnAnimalDay10()
    {
        Randomint = Random.Range(0, 10);

        if (Randomint == PrevRandomint)
        {
            Randomint = Random.Range(0, 10);
        }

        PrevRandomint = Randomint;

        Instantiate(Animals[Randomint], CustomerSpawn);
        StartCoroutine(Clocktimer());
    }

    public void SpawnAnimalDay11()
    {
        Randomint = Random.Range(0, 11);

        if (Randomint == PrevRandomint)
        {
            Randomint = Random.Range(0, 11);
        }

        PrevRandomint = Randomint;

        Instantiate(Animals[Randomint], CustomerSpawn);
        StartCoroutine(Clocktimer());
    }
    public void SpawnAnimalDay12()
    {
        Randomint = Random.Range(0, 12);

        if (Randomint == PrevRandomint)
        {
            Randomint = Random.Range(0, 12);
        }

        PrevRandomint = Randomint;

        Instantiate(Animals[Randomint], CustomerSpawn);
        StartCoroutine(Clocktimer());
    }
    public void SpawnAnimalDay13()
    {
        Randomint = Random.Range(0, 13);

        if (Randomint == PrevRandomint)
        {
            Randomint = Random.Range(0, 13);
        }

        PrevRandomint = Randomint;

        Instantiate(Animals[Randomint], CustomerSpawn);
        StartCoroutine(Clocktimer());
    }
    public void SpawnAnimalDay14()
    {
        Randomint = Random.Range(0, 14);

        if (Randomint == PrevRandomint)
        {
            Randomint = Random.Range(0, 14);
        }

        PrevRandomint = Randomint;

        Instantiate(Animals[Randomint], CustomerSpawn);
        StartCoroutine(Clocktimer());
    }
    public void SpawnAnimalDay15()
    {
        Randomint = Random.Range(0, 15);

        if (Randomint == PrevRandomint)
        {
            Randomint = Random.Range(0, 15);
        }

        PrevRandomint = Randomint;

        Instantiate(Animals[Randomint], CustomerSpawn);
        StartCoroutine(Clocktimer());
    }
    public void SpawnAnimalDay16()
    {
        Randomint = Random.Range(0, 16);

        if (Randomint == PrevRandomint)
        {
            Randomint = Random.Range(0, 16);
        }

        PrevRandomint = Randomint;

        Instantiate(Animals[Randomint], CustomerSpawn);
        StartCoroutine(Clocktimer());
    }
    public void SpawnAnimalDay17()
    {
        Randomint = Random.Range(0, 17);

        if (Randomint == PrevRandomint)
        {
            Randomint = Random.Range(0, 17);
        }

        PrevRandomint = Randomint;

        Instantiate(Animals[Randomint], CustomerSpawn);
        StartCoroutine(Clocktimer());
    }
    public void SpawnAnimalDay18()
    {
        Randomint = Random.Range(0, 18);

        if (Randomint == PrevRandomint)
        {
            Randomint = Random.Range(0, 18);
        }

        PrevRandomint = Randomint;

        Instantiate(Animals[Randomint], CustomerSpawn);
        StartCoroutine(Clocktimer());
    }
    public void SpawnAnimalDay19()
    {
        Randomint = Random.Range(0, 19);

        if (Randomint == PrevRandomint)
        {
            Randomint = Random.Range(0, 19);
        }

        PrevRandomint = Randomint;

        Instantiate(Animals[Randomint], CustomerSpawn);
        StartCoroutine(Clocktimer());
    }
    public void SpawnAnimalDay20()
    {
        Randomint = Random.Range(0, 20);

        if (Randomint == PrevRandomint)
        {
            Randomint = Random.Range(0, 20);
        }

        PrevRandomint = Randomint;

        Instantiate(Animals[Randomint], CustomerSpawn);
        StartCoroutine(Clocktimer());
    }
    public void SpawnAnimalDay21()
    {
        Randomint = Random.Range(0, 21);

        if (Randomint == PrevRandomint)
        {
            Randomint = Random.Range(0, 21);
        }

        PrevRandomint = Randomint;

        Instantiate(Animals[Randomint], CustomerSpawn);
        StartCoroutine(Clocktimer());
    }
    public void SpawnAnimalDay22()
    {
        Randomint = Random.Range(0, 22);

        if (Randomint == PrevRandomint)
        {
            Randomint = Random.Range(0, 22);
        }

        PrevRandomint = Randomint;

        Instantiate(Animals[Randomint], CustomerSpawn);
        StartCoroutine(Clocktimer());
    }

    IEnumerator Clocktimer()
    {
        yield return new WaitForSecondsRealtime(15f);
        DaySwitch();
    }
}
