using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIcontroller : MonoBehaviour
{
    public Text hungerText;
    public Text moodText;

    private Sheep sheep;

	// Use this for initialization
	void Start ()
    {
        sheep = FindObjectOfType<Sheep>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        hungerText.text = sheep.hunger.ToString();
        moodText.text = sheep.mood.ToString();
	}
}
