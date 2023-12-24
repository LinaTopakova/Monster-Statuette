using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;

public class Trigger9 : MonoBehaviour
{
    //public bool k_p = mycomponent.key_p;
    //public bool k = mycomponent.key9;
    [SerializeField] public mycomponent component;
    public bool k;
    public bool k_p;
    public Renderer r;
    public GameObject key;
    public static bool flag = false;
    string lname;

    private void Awake()
    {
        lname= SceneManager.GetActiveScene().name;
        switch (lname)
        {
        case "room9":
            k = component.GetKey9();
            break;
        case "Room3":
            k = component.GetKey3();
            break;
        case "Room4":
            k = component.GetKey4();
            break;
        }
        
        k_p = component.GetKey_p();
        r = key.GetComponent<Renderer>();
        
        if (k)
        {
            r.sortingOrder = 2;
        }
        else
        {
            r.sortingOrder = -2;
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
    
    private void FixedUpdate()
    {
        if (k && flag && Input.GetKey(KeyCode.E))
        {
            Time.timeScale = 0.1f;
            r.sortingOrder = -2;
            k = false;
            switch (lname)
            {
            case "room9":
                component.SetKey9(false);
                break;
            case "Room3":
                component.SetKey3(false);
                break;
            case "Room4":
                component.SetKey4(false);
                break;
            }
            
            k_p = true;
            component.SetKey_p(true);
            //Debug.Log(r.sortingOrder);
        }
        //inp = true;
        else if(!k && flag && k_p && Input.GetKey(KeyCode.E))
        {
            k = true;
            switch (lname)
            {
                case "room9":
                    component.SetKey9(true);
                    break;
                case "Room3":
                    component.SetKey3(true);
                    break;
                case "Room4":
                    component.SetKey4(true);
                    break;
            }
            k_p = false;
            component.SetKey_p(false);
            r.sortingOrder = 3;
            //Debug.Log(r.sortingOrder);
        }
    }
    
}
