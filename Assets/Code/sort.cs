using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class sort : MonoBehaviour
{
    public Vector3 V3;
    public Renderer r;
    void Start()
    {
        r = GetComponent<Renderer>();
    }
    private void Update()
    {
        V3 = this.transform.position;
        if ((V3.y<0.796f && V3.y>0.615f)&&(V3.x<1.11f && V3.x > 0.561f))
        {
            r.sortingOrder = 1;
        }
        else if((V3.y < 0.796f && V3.y > 0.615f) && (V3.x < -0.613f && V3.x > -1.05f))
        {
            r.sortingOrder = 1;
        }
        else if ((V3.y < -0.615f && V3.y > -0.796f) && (V3.x < -0.613f && V3.x > -1.05f))
        {
            r.sortingOrder = 5;
        }
        else if ((V3.y < -0.615f && V3.y > -0.796f) && (V3.x < 1.11f && V3.x > 0.561f))
        {
            r.sortingOrder = 5;
        }
        else
        {
            r.sortingOrder = 3;
        }
    }
}
