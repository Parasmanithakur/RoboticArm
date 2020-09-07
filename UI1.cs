using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI1 : MonoBehaviour
{

    public static bool GameisPaused = false;
    //public GameObject pauseMenuUI;
    public GameObject ControlsMenuUI;
    public GameObject ControlsAuto;
    public static bool Controlson = false;
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(GameisPaused);
       /* if (Input.GetKeyDown(KeyCode.Escape )&& (GameisPaused == false))
        {
            
            
                pauseMenuUI.SetActive(false);
                GameisPaused = true;
        }*/
    }
    public void Loadmenue()
    {
        if (Controlson == false)
        {
            ControlsMenuUI.SetActive(true);
            Controlson = true;
            UI1.GameisPaused = true;
            Debug.Log("Loading menu");

        }
        else
        {
            ControlsMenuUI.SetActive(false);
            Controlson = false;
            UI1.GameisPaused = true;
            Debug.Log("closing Menu");
        }
    }
    public void ChangeLevel()
    {
        SceneManager.LoadScene(1);
    }
    public void AutoMode()
    {


        if (IkManager1.IsIkON == true)
        {
            IkManager1.IsIkON = false;
            ControlsAuto.SetActive(false);
        }
        else
        {
            IkManager1.IsIkON = true;
            ControlsAuto.SetActive(true);
        }

    }

}
