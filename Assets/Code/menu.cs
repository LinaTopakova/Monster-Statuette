using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    [SerializeField] public Playercomponent component;
    string n;
    public void PlayGame() { 
    
        
        Time.timeScale = 1.0f;
        n = component.Getlast();
        switch (n)
        {
            case "Room1":
                SceneManager.LoadSceneAsync(1);
                break;
            case "Room2":
                SceneManager.LoadSceneAsync(2);
                break;
            case "Room3_1":
                SceneManager.LoadSceneAsync(2);
                break;
            case "Room3_2":
                SceneManager.LoadSceneAsync(5);
                break;
            case "Room4":
                SceneManager.LoadSceneAsync(4);
                break;
            case "room5":
                SceneManager.LoadSceneAsync(5);
                break;
            case "corridor":
                SceneManager.LoadSceneAsync(6);
                break;
            case "room9":
                SceneManager.LoadSceneAsync(7);
                break;
            case "room10":
                SceneManager.LoadSceneAsync(8);
                break;
        }
        
    }
    public void Quit()
    {
        Application.Quit();
    }

}
