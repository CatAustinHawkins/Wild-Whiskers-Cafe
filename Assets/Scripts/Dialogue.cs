using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI DialogueText;

    public GameObject SnakeOrder;

    public GameObject Buttons;
    public GameObject ThoughtBubble;

    public void YesButton()
    {
        DialogueText.text = "Yay!";
        Buttons.SetActive(false);
        SnakeOrder.SetActive(true);
        ThoughtBubble.SetActive(false);
    }

    public void NoButton()
    {
        DialogueText.text = "Oh...";
    }

}
