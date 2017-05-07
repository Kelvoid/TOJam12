using UnityEngine;
using System.Collections;

public class Grow : MonoBehaviour
{
    public void GrowFluff()
    {
        transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);
    }

    public void ShrinkFluff()
    {
        transform.localScale -= new Vector3(0.05f, 0.05f, 0.05f);
    }
}
