using UnityEngine;
using System.Collections;

public class Sheep : MonoBehaviour
{
    public string sheepName;
    public int hunger;
    public int mood;

    public Color woolColour;
    public GameObject eyes;


	void Start ()
    {
        hunger = 100;
        mood = 100;
	}
	
	void Update ()
    {
	    
	}
}
