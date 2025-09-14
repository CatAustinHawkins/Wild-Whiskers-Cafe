using UnityEngine;

//Used on the main menu
//When clicking the cat image, it will either meow or bark
//1 in 100 chance to bark

//NEEDS ACHIEVEMENT ADDED


public class ButtonNoise : MonoBehaviour
{
    public AudioSource[] Speak; //Four Meow Sound Effects
    public AudioSource Woof; //Bark Sound Effect

    public int random; //Which Meow Sound is Played
    public int random2; //Check if Dog Sound is to be played

    //On Cat images on MainMenu
   public void Clicked()
    {
        random = Random.Range(0, 4);
        random2 = Random.Range(0, 101);

        if(random2 == 100)
        {
            Woof.Play();
        }
        else
        {
            Speak[random].Play();
        }
    }
}
