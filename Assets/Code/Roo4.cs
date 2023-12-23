using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roo4 : MonoBehaviour
{
    [SerializeField] public mycomponent component;
    public bool k_p;
    public GameObject a;
    public Renderer r;
    public Animation anim;
    void Awake()
    {
        k_p = component.GetKey_p();
        if (k_p)
        {
            r = a.GetComponent<Renderer>();
            r.sortingOrder = 5;
            anim = GetComponent<Animation>();
            anim.Play("ChestOpen");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
