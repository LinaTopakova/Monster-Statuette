using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Room1 : MonoBehaviour
{
    [SerializeField] public Playercomponent component;
    public string simple_scene;
    public string last_scene;
    public Vector3 t;
    public GameObject player;

    void Awake()
    {
        simple_scene = SceneManager.GetActiveScene().name;
        last_scene = component.Getlast();
        Debug.Log(last_scene);
        switch (simple_scene)
        {
        case "Room1":
            t = component.Getroom1();
            break;
        case "Room2":
            t = component.Getroom2();
            break;
        case "corridor":
            t = component.Getcorridor();
            break;
        case "Room3":
            if (last_scene == "room5")

            {
                t = component.Getroom3_2();
            }
            else
            {
                t = component.Getroom3_1();
            }
            break;
        case "Room4":
            t = component.Getroom4();
            break;
        case "room5":
            t = component.Getroom5();
            break;
        case "room9":
            t = component.Getroom9();
            break;
        case "room10":
            t= component.Getroom10();
            break;
        }
        
        player.transform.position = new Vector3(t.x, t.y, t.z);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        t = player.transform.position;
        switch (simple_scene)
        {
            case "Room1":
                component.Setroom1(t);
                break;
            case "Room2":
                component.Setroom2(t);
                break;
            case "corridor":
                component.Setcorridor(t);
                break;
            case "Room3":
                break;
            case "Room4":
                component.Setroom4(t);
                break;
            case "room5":
                component.Setroom5(t);
                break;
            case "room9":
                component.Setroom9(t);
                break;
            case "room10":
                component.Setroom10(t);
                break;
        }
       
    }
}
