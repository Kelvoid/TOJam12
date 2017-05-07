using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour
{
    private Vector3 mousePos;
    public Sprite cursorGraphic;

    public GameObject food;

    private GameObject currentlyHeldItem;

	void Update ()
    {
        mousePos = Input.mousePosition;

        if (Input.GetButtonDown("Fire1"))
        {
            CreateFood();    
        }
    }

    void CreateFood()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            Instantiate(food, new Vector3(hit.point.x, 1, hit.point.z), gameObject.transform.rotation);
        }
    }
}
