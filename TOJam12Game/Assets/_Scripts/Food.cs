using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Food : MonoBehaviour
{
    public int hungerFill;
    public float timeToDestroy;

    private Sheep sheep;
    private PointsOfIntrest pointsOfIntrest;

	void Awake ()
    {
        sheep = FindObjectOfType<Sheep>();
        pointsOfIntrest = FindObjectOfType<PointsOfIntrest>();
        pointsOfIntrest.listOfPoints.Add(gameObject.transform.position);
	}

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Sheep"))
        {
            Debug.Log("Ate Apple");
            sheep.hunger += hungerFill;
            pointsOfIntrest.listOfPoints.Remove(gameObject.transform.position);
            Destroy(gameObject);
        }
    }
}
