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
        if ((V3.y<0.797 && V3.y>0.631)&&(V3.x<0.919 && V3.x > 0.534))
        {
            r.sortingOrder = 1;
        }
        else
        {
            r.sortingOrder = 2;
        }
    }
}
