using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Door : MonoBehaviour
{
    public int flag;
    public void Start()
    {
        flag = 0;
    }
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            flag = 1;
        }
        
    }
    void OnTriggerExit2D(Collider2D other)
    {
        flag = 0;
    }
    void Update()
    {
        if (flag == 1 && Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadSceneAsync(2);
        }
    }

}
