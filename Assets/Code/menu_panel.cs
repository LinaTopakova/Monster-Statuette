using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_panel : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Control;
    // Start is called before the first frame update
    public void ControlPlay()
    {
        Panel.SetActive(false);
        Control.SetActive(true);
    }
    public void PanelPlay()
    {
        Panel.SetActive(true);
        Control.SetActive(false);
    }
}
