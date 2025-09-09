using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Customers : MonoBehaviour
{

    //check if a table is occupied
    //

    public GameObject[] target;

    NavMeshAgent agent;

    public GameObject TableCheckGO;
    public TableCheck TableCheckScript;

    public int Table;

    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        target[0] = GameObject.FindWithTag("CustomerSpawn");
        target[1] = GameObject.FindWithTag("Table1");
        target[2] = GameObject.FindWithTag("Table2");
        target[3] = GameObject.FindWithTag("Table3");
        target[4] = GameObject.FindWithTag("Table4");
        target[5] = GameObject.FindWithTag("LeavingArea");

        TableCheckGO = GameObject.FindWithTag("TableCheck");
        TableCheckScript = TableCheckGO.GetComponent<TableCheck>();

        Check1();
        StartCoroutine(Mealtimer());
    }

    public void Update()
    {
        agent.SetDestination(target[Table].transform.position);
    }

    public void Check1()
    {
        if(TableCheckScript.Table1Busy == false)
        {
            Table = 1;
            TableCheckScript.Table1Busy = true;
        }
        else
        {
            Check2();
        }
    }

    public void Check2()
    {
        if (TableCheckScript.Table2Active == true && TableCheckScript.Table2Busy == false)
        {
            Table = 2;
            TableCheckScript.Table2Busy = true;
        }
        else
        {
            Check3();
        }
    }

    public void Check3()
    {
        if (TableCheckScript.Table3Active == true && TableCheckScript.Table3Busy == false)
        {
            Table = 3;
            TableCheckScript.Table3Busy = true;
        }
        else
        {
            Check4();
        }
    }


    public void Check4()
    {
        if (TableCheckScript.Table4Active == true && TableCheckScript.Table4Busy == false)
        {
            Table = 4;
            TableCheckScript.Table4Busy = true;
        }
        else
        {
            StartCoroutine(Clocktimer());
        }
    }

    IEnumerator Clocktimer()
    {
        Debug.Log("Waiting to Leave");
        yield return new WaitForSecondsRealtime(7.5f);
        Table = 5;
        Debug.Log("Left");
        yield return new WaitForSecondsRealtime(1.5f);
        Destroy(gameObject);

    }


    IEnumerator Mealtimer()
    {
        yield return new WaitForSecondsRealtime(7.5f);
        Debug.Log("MealTime");
    }
}

