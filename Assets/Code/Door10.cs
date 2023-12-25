using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door10 : MonoBehaviour
{
    [SerializeField] public Playercomponent component;
    [SerializeField] public mycomponent k;
    public GameObject monolog;
    public Renderer r;
    public bool flag;
  
    void Start()
    {
        flag = false;
        r = monolog.GetComponent<Renderer>();
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        flag = true;
    }
    // Update is called once per frame
    void OnTriggerExit2D(Collider2D other)
    {
        flag = false;
    }

    void FixedUpdate()
    {
        if(flag && k.GetKey_p() && Input.GetKey(KeyCode.Return))
        {
            r.sortingOrder = -1;
            component.Setlast("Room2");
            SceneManager.LoadSceneAsync(8);
        }
        else if(flag && !k.GetKey_p() && Input.GetKey(KeyCode.Return))
        {
            r.sortingOrder = 5;
        }
        else if (!flag)
        {
            r.sortingOrder = -1;
        }
    }
}
