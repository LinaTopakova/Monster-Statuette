using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anim : MonoBehaviour
{
    [SerializeField] public mycomponent component;
    [SerializeField] public Playercomponent c;
    public bool k_p;
    public string last;
    public GameObject a;
    public GameObject b;
    public Renderer r;
    public Animation an;
    private Animator _animator;
    bool flag = true;
    public static bool Game_Plocho = false;
    public GameObject PlochoMenu;
    public Over over;

    public void Menu()
    {
        if (c.Getlast() == "corridor")
        {
            SceneManager.LoadSceneAsync(6);
        }
        else
        {
            SceneManager.LoadSceneAsync(5);
        }
        
    }

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        
    }
    public void Stop_anim()
    {
        _animator.SetBool("flag", false);
    }
    
    void Start()
    {
        
        k_p = component.GetKey_p();
        last = c.Getlast();
        if (k_p)
        {
            if (last == "room5")
            {
                r = a.GetComponent<Renderer>();
            }
            else if (last == "corridor")
            {
                r = b.GetComponent<Renderer>();
            }
            r.sortingOrder = 5;
            an = GetComponent<Animation>();
            flag = true;
            over.Over_d();
            an.Play("ChestOpen");
        }
        else
        {
            r.sortingOrder = -1;
        }

    }
    private void Update()
    {
        if (!flag)
        {
            an.Stop();
            Time.timeScale = 0.0f;
            r.sortingOrder = -1;
        }

    }
}
