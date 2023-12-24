using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roo4 : MonoBehaviour
{
    [SerializeField] public mycomponent component;
    [SerializeField] public Playercomponent c;
    public bool k_p;
    public string last;
    public GameObject a;
    public GameObject b;
    public Renderer r;
    public Animation anim;
    public Animation an;
    void Start()
    {
        k_p = component.GetKey_p();
        last = c.Getlast();
        if (k_p)
        {
            if(last == "room5")
            {
                r = a.GetComponent<Renderer>();
                r.sortingOrder = 5;
                anim = GetComponent<Animation>();
                anim.Play("ChestOpen");
    
            }
            else if (last == "corridor")
            {
                r = b.GetComponent<Renderer>();
                r.sortingOrder = 5;
                an = GetComponent<Animation>();
                an.Play("ChestOpen");
            }
            anim.Stop();

        }

    }

    public void Stop(string name)
    {
        
    }
}
