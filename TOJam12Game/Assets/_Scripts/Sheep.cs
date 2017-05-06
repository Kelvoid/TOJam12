using UnityEngine;
using System.Collections;

public class Sheep : MonoBehaviour
{
    public string sheepName;
    public int hunger;
    public int mood;

    public Color woolColour;
    public GameObject eyes;

    public float attentionDist;

	void Start ()
    {
        hunger = 100;
        mood = 100;
	}
	
	void Update ()
    {

	    if(hunger <= 0)
        {
            //GameOver
        }

        Debug.Log(hunger);
	}

    void Hunger()
    {
        //Controlls Hunger levels
    }
}
