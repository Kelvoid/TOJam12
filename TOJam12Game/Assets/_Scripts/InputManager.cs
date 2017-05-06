using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour
{
    private Vector3 mousePos;
    public Sprite cursorGraphic;

    public GameObject food;

	void Update ()
    {
        mousePos = Input.mousePosition;

        if (Input.GetButtonUp("Fire1"))
        {
            Clicked();
        }

        if (Input.GetButton("Fire1"))
        {
            ClickHeld();
        }
	}

    void Clicked()
    {
        Ray ray = Camera.main.ScreenPointToRay(mousePos);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if(hit.collider.tag == "DropArea")
            {
                Instantiate(food, new Vector3(hit.point.x, 1, hit.point.z), transform.rotation);
            }
            else
            {
                Debug.Log(hit.collider.name);
            }

        }
    }

    void ClickHeld()
    {
        //Held down
    }
}
