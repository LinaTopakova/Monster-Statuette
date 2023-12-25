using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statuette : MonoBehaviour
{
    [SerializeField] public mycomponent component;
    public Renderer r;
    public GameObject s;
    public static bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        r = s.GetComponent<Renderer>();
        flag = false;
        if (component.GetStatuette())
        {
            r.sortingOrder = 1;
        }
        else
        {
            r.sortingOrder = -1;
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        flag = true;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        flag = false;
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if(flag && component.GetStatuette() && Input.GetKey(KeyCode.E)) 
        {
            Time.timeScale = 0.6f;
            r.sortingOrder = -2;
            component.SetStatuette(false);
            component.SetStatuette_p(true);
        }
        else if (!component.GetStatuette() && flag && component.GetStatuette_p() && Input.GetKey(KeyCode.E))
        {
            Time.timeScale = 1.0f;
            r.sortingOrder = 1;
            component.SetStatuette(true);
            component.SetStatuette_p(false);
        }
    }
}
