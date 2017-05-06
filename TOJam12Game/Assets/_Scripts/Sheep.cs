using UnityEngine;
using System.Collections;

public class Sheep : MonoBehaviour
{
    public string sheepName;
    public int hunger;
    public int mood;

    public bool attentionGrabbed;

    public Color woolColour;
    public GameObject eyes;

    public float attentionDist;
    public Vector3 currentPointofIntrest;

    private PointsOfIntrest pointsOfIntrest;

	void Start ()
    {
        pointsOfIntrest = GetComponent<PointsOfIntrest>();
        hunger = 100;
        mood = 100;
	}
	
	void Update ()
    {
        if (pointsOfIntrest.listOfPoints.Count > 0f)
        {
            for (int i = 0; i < pointsOfIntrest.listOfPoints.Count; i++)
            {
                if (Vector3.Distance(gameObject.transform.position, pointsOfIntrest.listOfPoints[i]) < attentionDist)
                {
                    attentionGrabbed = true;
                    currentPointofIntrest = pointsOfIntrest.listOfPoints[i];
                }
            }
        }
        else
        {
            attentionGrabbed = false;
        }

        if (hunger <= 0)
        {
            //GameOver
        }
	}

    void Hunger()
    {
        //Controlls Hunger levels
    }
}
