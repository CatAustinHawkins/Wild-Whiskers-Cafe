using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerSetup : MonoBehaviour
{

    public TMP_InputField NameEntry;

    public string PlayerName;

    public Image Choice1;
    public Image Choice2;
    public Image Choice3;
    public Image Choice4;


    public bool Choice1Selected;
    public bool Choice2Selected;
    public bool Choice3Selected;
    public bool Choice4Selected;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);

    }

    public void InputField()
    {
        PlayerName = NameEntry.text.ToString();
        if(string.IsNullOrWhiteSpace(PlayerName))
        {
            PlayerName = "Cat";
        }
    }

    public void PlayerAvatarChoice1()
    {
        Choice1Selected = true;
        Choice2Selected = false;
        Choice3Selected = false;
        Choice4Selected = false;

        Choice1.color = new Color32(171, 171, 171, 255);
        Choice2.color = new Color32(255, 255, 255, 255);
        Choice3.color = new Color32(255, 255, 255, 255);
        Choice4.color = new Color32(255, 255, 255, 255);
    }
    public void PlayerAvatarChoice2()
    {
        Choice2Selected = true;
        Choice1Selected = false;
        Choice3Selected = false;
        Choice4Selected = false;

        Choice2.color = new Color32(171, 171, 171, 255);
        Choice1.color = new Color32(255, 255, 255, 255);
        Choice3.color = new Color32(255, 255, 255, 255);
        Choice4.color = new Color32(255, 255, 255, 255);
    }
    public void PlayerAvatarChoice3()
    {
        Choice3Selected = true;
        Choice1Selected = false;
        Choice2Selected = false;
        Choice4Selected = false;

        Choice3.color = new Color32(171, 171, 171, 255);
        Choice1.color = new Color32(255, 255, 255, 255);
        Choice2.color = new Color32(255, 255, 255, 255);
        Choice4.color = new Color32(255, 255, 255, 255);
    }
    public void PlayerAvatarChoice4()
    {
        Choice4Selected = true;
        Choice1Selected = false;
        Choice2Selected = false;
        Choice3Selected = false;

        Choice4.color = new Color32(171, 171, 171, 255);
        Choice1.color = new Color32(255, 255, 255, 255);
        Choice2.color = new Color32(255, 255, 255, 255);
        Choice3.color = new Color32(255, 255, 255, 255);
    }

    public void Finished()
    {
        SceneManager.LoadScene("MainLevel");
    }


}
