using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Room2_2 : MonoBehaviour
{
    [SerializeField] public Playercomponent component;
    public string simple_scene;
    public string last_scene;
    public Vector3 t;
    public GameObject player;
    void Awake()
    {
        simple_scene = SceneManager.GetActiveScene().name;
        t = component.Getroom2();
        Debug.Log(t);
        player.transform.position = new Vector3(t.x,t.y,t.z);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        t = player.transform.position;
        component.Setroom2(t);
        component.Setlast(simple_scene);
    }
}
