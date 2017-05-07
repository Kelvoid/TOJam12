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
        InvokeRepeating("Hunger", 5, 5);
        hunger = 100;
        mood = 100;
	}
	
	void Update ()
    {
        attentionGrabbed = false;
        if (pointsOfIntrest.listOfPoints.Count > 0)
        {            
            float closestDistance = float.PositiveInfinity;
            for (int i = 0; i < pointsOfIntrest.listOfPoints.Count; i++)
            {
                float d = Vector3.Distance(gameObject.transform.position, pointsOfIntrest.listOfPoints[i].transform.position);
                if (d < attentionDist && d<closestDistance)
                {
                    closestDistance = d;
                    attentionGrabbed = true;
                    currentPointofIntrest = pointsOfIntrest.listOfPoints[i].transform.position;
                }
            }
        }

        if(hunger <= 0f)
        {
            //Gameover
        }
	}

    void Hunger()
    {
        hunger -= 10;
    }
}
