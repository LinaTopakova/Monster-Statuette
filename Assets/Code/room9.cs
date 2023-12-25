using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;

public class room9 : MonoBehaviour
{
    public static bool flag = false;
    public GameObject monolog;
    private Renderer r;
    // Start is called before the first frame update
    void Awake()
    {
        r = monolog.GetComponent<Renderer>();
        flag = false;
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        flag = true;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        flag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (flag)
        {
            r.sortingOrder = 3;
        }
        else
        {
            r.sortingOrder = -1;
        }
    }
}
