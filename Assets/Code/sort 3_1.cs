using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;

public class sort3_1 : MonoBehaviour
{
    public GameObject stone;
    public Renderer r;

    void Start()
    {
        r = stone.GetComponent<Renderer>();

    }
    void OnTriggerExit2D(Collider2D other)
    {
        r.sortingOrder = 1;
    }
}
