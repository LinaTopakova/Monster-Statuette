using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Door2 : MonoBehaviour
{
    public static bool flag = false;
    public void Start()
    {
        flag = false;
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            flag = true;
        }

    }
    void OnTriggerExit2D(Collider2D other)
    {
        flag = false;
    }
    void Update()
    {
        if (flag && Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadSceneAsync(2);
        }
    }
}