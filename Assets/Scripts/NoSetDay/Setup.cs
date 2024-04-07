using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setup : MonoBehaviour
{

    public bool Under12;
    public bool Over13;

    public bool Easy;
    public bool Normal;
    public bool Hard;

    public bool Under12Easy;
    public bool Under12Normal;
    public bool Under12Hard;

    public bool Over13Easy;
    public bool Over13Normal;
    public bool Over13Hard;

    public Image Choice1;
    public Image Choice2;
    public Image Choice3;
    public Image Choice4;
    public Image Choice5;

    public int GameMode = 4;

    public void Start()
    {
        DontDestroyOnLoad(this.gameObject); //dont destroy - so the player script can access it 
        //Over13Normal = true;
    }
    public void Under12Selected()
    {
        Choice1.color = new Color32(171, 171, 171, 255);
        Choice2.color = new Color32(255, 255, 255, 255);

        Under12 = true;
        Over13 = false;

        if(Easy)
        {
            Under12Easy = true;
            Under12Normal = false;
            Under12Hard = false;
            Over13Easy = false;
            Over13Normal = false;
            Over13Hard = false;

            GameMode = 1;
        }

        if (Normal)
        {
            Under12Easy = false;
            Under12Normal = true;
            Under12Hard = false;
            Over13Easy = false;
            Over13Normal = false;
            Over13Hard = false;

            GameMode = 2;

        }

        if (Hard)
        {
            Under12Easy = false;
            Under12Normal = false;
            Under12Hard = true;
            Over13Easy = false;
            Over13Normal = false;
            Over13Hard = false;

            GameMode = 3;

        }
    }

    public void Over13Selected()
    {
        Choice2.color = new Color32(171, 171, 171, 255);
        Choice1.color = new Color32(255, 255, 255, 255);

        Under12 = false;
        Over13 = true;

        if (Easy)
        {
            Under12Easy = false;
            Under12Normal = false;
            Under12Hard = false;
            Over13Easy = true;
            Over13Normal = false;
            Over13Hard = false;

            GameMode = 4;

        }

        if (Normal)
        {
            Under12Easy = false;
            Under12Normal = false;
            Under12Hard = false;
            Over13Easy = false;
            Over13Normal = true;
            Over13Hard = false;

            GameMode = 5;

        }

        if (Hard)
        {
            Under12Easy = false;
            Under12Normal = false;
            Under12Hard = false;
            Over13Easy = false;
            Over13Normal = false;
            Over13Hard = true;

            GameMode = 6;

        }
    }

    public void EasyModeSelected()
    {
        Choice3.color = new Color32(171, 171, 171, 255);
        Choice4.color = new Color32(255, 255, 255, 255);
        Choice5.color = new Color32(255, 255, 255, 255);

        Easy = true;
        Normal = false;
        Hard = false;
    
        if(Under12)
        {
            Under12Easy = true;
            Under12Normal = false;
            Under12Hard = false;
            Over13Easy = false;
            Over13Normal = false;
            Over13Hard = false;

            GameMode = 1;

        }

        if (Over13)
        {
            Under12Easy = false;
            Under12Normal = false;
            Under12Hard = false;
            Over13Easy = true;
            Over13Normal = false;
            Over13Hard = false;

            GameMode = 4;
        }
    }

    public void NormalModeSelected()
    {
        Easy = false;
        Normal = true;
        Hard = false;
        Choice3.color = new Color32(255, 255, 255, 255);
        Choice4.color = new Color32(171, 171, 171, 255);
        Choice5.color = new Color32(255, 255, 255, 255);

        if (Under12)
        {
            Under12Easy = false;
            Under12Normal = true;
            Under12Hard = false;
            Over13Easy = false;
            Over13Normal = false;
            Over13Hard = false;

            GameMode = 2;
        }

        if (Over13)
        {
            Under12Easy = false;
            Under12Normal = false;
            Under12Hard = false;
            Over13Easy = false;
            Over13Normal = true;
            Over13Hard = false;

            GameMode = 5;
        }
    }


    public void HardModeSelected()
    {
        Easy = false;
        Normal = false;
        Hard = true;
        Choice3.color = new Color32(255, 255, 255, 255);
        Choice4.color = new Color32(255, 255, 255, 255);
        Choice5.color = new Color32(171, 171, 171, 255);

        if (Under12)
        {
            Under12Easy = false;
            Under12Normal = false;
            Under12Hard = true;
            Over13Easy = false;
            Over13Normal = false;
            Over13Hard = false;

            GameMode = 3;
        }

        if (Over13)
        {
            Under12Easy = false;
            Under12Normal = false;
            Under12Hard = false;
            Over13Easy = false;
            Over13Normal = false;
            Over13Hard = true;
            GameMode = 6;
        }
    }


    public void Save()
    {
        PlayerPrefs.SetInt("Gamemode", GameMode);

    }

    public void Load()
    {

    }
}
