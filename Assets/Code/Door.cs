using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Door : MonoBehaviour
{
    [SerializeField] public Playercomponent component;
    public bool flag;
    //public bool key;
    string n;
    public void Start()
    {
        flag = false;
        n = gameObject.name;
    }
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        flag = true;


    }
    void OnTriggerExit2D(Collider2D other)
    {
        flag = false;
    }
    void FixedUpdate()
    {
        //Debug.Log(flag);
        if (flag  && Input.GetKey(KeyCode.Return))
        {
            switch (n)
            {
            case "Door_in1":
                component.Setlast("Room2");
                SceneManager.LoadSceneAsync(1);
                break;
            case "Door_in2":
                component.Setlast("Room1");
                SceneManager.LoadSceneAsync(2);
                break;
            case "Door_in3_1":
                component.Setlast("Room2");

                SceneManager.LoadSceneAsync(3);
                break;
            case "Door_in3_2":
                component.Setlast("room5");
                SceneManager.LoadSceneAsync(3);
                break;
            case "Door_in4_1":
                component.Setlast("corridor");
                SceneManager.LoadSceneAsync(4);
                break;
            case "Door_in4_2":
                component.Setlast("room5");
                SceneManager.LoadSceneAsync(4);
                break;
            case "Door_in5":
                component.Setlast("Room4");
                SceneManager.LoadSceneAsync(5);
                break;
            case "Corridor":
                component.Setlast("Room2");
                SceneManager.LoadSceneAsync(6);
                break;
            case "Door_in_exit":
                component.Setlast("Room1");
                SceneManager.LoadSceneAsync(0);
                break;
            case "Door_in10":
                component.Setlast("Room2");
                SceneManager.LoadSceneAsync(8);
                break;
            case "Door_in9":
                SceneManager.LoadSceneAsync(7);
                break;
            }
            
        }
    }

}
