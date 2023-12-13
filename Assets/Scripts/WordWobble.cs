using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Script by Madalaski
//https://youtu.be/FgWVW2PL1bQ?si=-Efsc2-gfgUcEzaF 
//Edited by @vimtutorials5234


public class RainbowText : MonoBehaviour
{
    //Variables for Word Change
    [SerializeField] bool applyOnlyToSelection;
    [TextArea(5, 5)]                             
    //make this area bigger if you need to add more lines
    [SerializeField] string textToChangeColor;
    int specificWordIndex;

    //Variables for Text Change
    TMP_Text textMesh;
    Mesh mesh;
    Vector3[] vertices;
    List<int> wordIndexes;
    List<int> wordLengths;

    //Wobbling Variables
    Vector3 offset;
    [SerializeField] bool wobbleText = false;
    [SerializeField] float wobblingSpeed = 1f;

    //global Variables
    TMP_Text tempTextMesh;
    string tempString;


    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TMP_Text>();
        wordIndexes = new List<int>();
        wordLengths = new List<int>();

        if (applyOnlyToSelection)
        {
            char[] tempChars = textToChangeColor.ToLower().ToCharArray();
            tempString = textMesh.text.ToLower();

            for (int i = 0; i < tempString.Length; i++)
            {
                if (tempString[i].CompareTo(tempChars[0]) == 0)      
                    //check if the first letter of the Selection is found
                {
                    for (int j = 1; j < tempChars.Length; j++)      
                        //Go over every character in our selection
                    {
                        if (tempString[i + j].CompareTo(tempChars[j]) != 0)  
                    //if next character is not the character in our selection, go back to the 1st For Loop
                        {
                            break;
                        }

                        if (j == tempChars.Length - 1)       
                            //if every character was correct, We found our selection!!
                        {
                            print("Found the word!");
                            wordIndexes.Add(i);
                            wordLengths.Add(tempChars.Length);
                            tempString = textToChangeColor;
                            return;
                        }
                    }
                }

           //Our selection was not found, Script will deactivate itself because it wont do anything anyways
                if (i == tempString.Length - 1) { print("Word not found!"); this.enabled = false; }
            }
        }
        else
        {
            wordIndexes.Add(0); //wordIndexes needs to start with an index of 0
            tempString = textMesh.text;
            for (int index = tempString.IndexOf(' '); index > -1; index = tempString.IndexOf(' ', index + 1))
            {
                wordLengths.Add(index - wordIndexes[wordIndexes.Count - 1]);
                wordIndexes.Add(index + 1);
            }
            wordLengths.Add(tempString.Length - wordIndexes[wordIndexes.Count - 1]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.ForceMeshUpdate();
        mesh = textMesh.mesh;
        vertices = mesh.vertices;

        Color[] colors = mesh.colors;

        for (int w = 0; w < wordIndexes.Count; w++)
        {
            int wordIndex = wordIndexes[w];
            if (wobbleText) offset = Wobble(Time.time * wobblingSpeed + w);

            for (int i = 0; i < wordLengths[w]; i++)
            {
                TMP_CharacterInfo c = textMesh.textInfo.characterInfo[wordIndex + i];

                int index = c.vertexIndex;

                if (applyOnlyToSelection) { if (index == 0) continue; } 
                //if there is a blank character, go to the next character instead


                if (wobbleText)
                {
                    vertices[index] += offset;
                    vertices[index + 1] += offset;
                    vertices[index + 2] += offset;
                    vertices[index + 3] += offset;
                }
            }
        }

        mesh.vertices = vertices;
        mesh.colors = colors;
        textMesh.canvasRenderer.SetMesh(mesh);
    }

    Vector2 Wobble(float time)
    {
        return new Vector2(Mathf.Sin(time * 3.3f), Mathf.Cos(time * 2.5f));
    }
}