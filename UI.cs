using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{

    

    public GameObject pauseMenuUi;
    public GameObject controlMenuUi;

   
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (UI1.GameisPaused)
            {
                Resume1();
               
            }
            else
            {
                Pause();
                
            }
        }
    }
    public void Resume1()
    {
        pauseMenuUi.SetActive(false);
        controlMenuUi.SetActive(false);
        Time.timeScale = 1f;
        UI1.GameisPaused = false;
    }
    public void AutoMode()
    {

        pauseMenuUi.SetActive(false);
        IkManager1.IsIkON = true;
        UI1.GameisPaused = false;
    }
     public void Pause()
    {
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        UI1.GameisPaused = true;
    }
    public void Loadmenue()
    {
        controlMenuUi.SetActive(true);
        pauseMenuUi.SetActive(false);
        UI1.GameisPaused = true;
        Debug.Log("Loading menu");
    }
    public void QuitGame()
    {
        Debug.Log("QuitGame");
    }
}
