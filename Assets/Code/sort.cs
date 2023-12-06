using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class sort : MonoBehaviour
{
    public Vector3 V3;
    private Renderer r;
    void Start()
    {
        r = GetComponent<Renderer>();
    }
    private void Update()
    {
        V3 = this.transform.position;
        if ((V3.y<0.796 && V3.y>0.615)&&(V3.x<1.11 && V3.x > 0.561))
        {
            r.sortingOrder = 1;
        }
        else if((V3.y < 0.796 && V3.y > 0.615) && (V3.x < -0.613 && V3.x > -1.05))
        {
            r.sortingOrder = 1;
        }
        else if ((V3.y < -0.615 && V3.y > -0.796) && (V3.x < -0.613 && V3.x > -1.05))
        {
            r.sortingOrder = 3;
        }
        else if ((V3.y < -0.615 && V3.y > -0.796) && (V3.x < 1.11 && V3.x > 0.561))
        {
            r.sortingOrder = 3;
        }
        else
        {
            r.sortingOrder = 2;
        }
    }
}
