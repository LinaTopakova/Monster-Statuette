using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;

public class sort3_2 : MonoBehaviour
{
    public GameObject stone;
    public GameObject player;
    public Renderer r;
    public Renderer r_p;
    public bool flag;
    void Start()
    {
        r = stone.GetComponent<Renderer>();
        r_p = player.GetComponent<Renderer>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        flag = true;
        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        flag = false;

    }

    private void Update()
    {
        if (flag)
        {
            r.sortingOrder = 3;
            r_p.sortingOrder = 1;
            Debug.Log(r.sortingOrder);
            Debug.Log(r_p.sortingOrder);
        }
        else
        {
            r.sortingOrder = 1;
            r_p.sortingOrder = 2;
            Debug.Log(r.sortingOrder);
            Debug.Log(r_p.sortingOrder);
        }
    }
}
