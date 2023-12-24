using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Playercomponent : MonoBehaviour
{
    [SerializeField] public static string last_scene = "Room1";
    [SerializeField] public static Vector3 room1 = new Vector3(-0.006f ,- 0.899f, 0.0f);
    [SerializeField] public static Vector3 room2 = new Vector3(-1.43f, 0.04f, 0.0f);
    [SerializeField] public static Vector3 room3_1 = new Vector3(-0.961f, -0.907f, 0.0f);
    [SerializeField] public static Vector3 room3_2 = new Vector3(0.966f, 0.775f, 0.0f);
    [SerializeField] public static Vector3 room4 = new Vector3(0.01f, -1.63f, 0.0f);
    [SerializeField] public static Vector3 corridor = new Vector3(-2.304f, -0.426f, 0.0f);
    [SerializeField] public static Vector3 room5 = new Vector3(0.961f, -0.914f, 0.0f);
    [SerializeField] public static Vector3 room9 = new Vector3(-1.433f, -0.215f, 0.0f);
    [SerializeField] public static Vector3 room10 = new Vector3(0.956f, -0.896f, 0.0f);
    public string Getlast()
    {
        return last_scene;
    }

    public void Setlast(string new_scene)
    {
        last_scene = new_scene;
    }
    public Vector3 Getroom1() 
    { 
        return room1; 
    }
    public void Setroom1(Vector3 v)
    {
        room1 = v;   
    }
    public Vector3 Getroom2()
    {
        return room2;
    }
    public void Setroom2(Vector3 v)
    {
        room2 = v;
    }
    public Vector3 Getroom3_1()
    {
        return room3_1;
    }
    public void Setroom3_1(Vector3 v)
    {
        room3_1 = v;
    }
    public Vector3 Getroom3_2()
    {
        return room3_2;
    }
    public void Setroom3_2(Vector3 v)
    {
        room3_2 = v;
    }
    public Vector3 Getroom4()
    {
        return room4;
    }
    public void Setroom4(Vector3 v)
    {
        room4 = v;
    }
    public Vector3 Getcorridor()
    {
        return corridor;
    }
    public void Setcorridor(Vector3 v)
    {
        corridor = v;
    }
    public Vector3 Getroom5()
    {
        return room5;
    }
    public void Setroom5(Vector3 v)
    {
        room5 = v;
    }
    public Vector3 Getroom9()
    {
        return room9;
    }
    public void Setroom9(Vector3 v)
    {
        room9 = v;
    }
    public Vector3 Getroom10()
    {
        return room10;
    }
    public void Setroom10(Vector3 v)
    {
        room10 = v;
    }
}
