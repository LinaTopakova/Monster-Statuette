using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door_Exit : MonoBehaviour
{
    [SerializeField] public Playercomponent component;
    [SerializeField] public mycomponent c;
    public bool flag;
    public GameObject monolog;
    public Renderer r;
    void Start()
    {
        flag = false;
        r = monolog.GetComponent<Renderer>();
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
    void FixedUpdate()
    {
        if (flag && c.GetStatuette_p() && Input.GetKey(KeyCode.Return))
        {
            r.sortingOrder = -1;
            component.Setlast("Room1");
            SceneManager.LoadSceneAsync(0);
        }
        else if (flag && !c.GetStatuette_p())
        {
            r.sortingOrder = 5;
        }
        else if (!flag)
        {
            r.sortingOrder = -1;
        }
    }
}
