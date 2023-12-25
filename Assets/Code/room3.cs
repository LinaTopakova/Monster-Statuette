using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;

public class room3 : MonoBehaviour
{
    [SerializeField] public mycomponent component;
    public static bool flag = false;
    public GameObject monolog;
    private Renderer r;
    string n;
    bool ks;
    // Start is called before the first frame update
    void Awake()
    {
        r = monolog.GetComponent<Renderer>();
        flag = false;
        n = gameObject.name;
        if (n == "Trigger3_2")
        {
            ks = component.GetKey_p();
        }
        else
        {
            ks = component.GetKey9();
        }
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
        if (flag && ks)
        {
            r.sortingOrder = 3;
            if (n == "Trigger3_2")
            {
                ks = component.GetKey_p();
            }
            else
            {
                ks = component.GetKey9();
            }
        }
        else
        {
            r.sortingOrder = -1;
        }
    }
}
