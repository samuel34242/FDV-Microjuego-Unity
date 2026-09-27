using UnityEngine;

public class Pause : MonoBehaviour
{


    private bool isPaused = false;

    public GameObject pauseMenu;

    void Start()
    {
       
        pauseMenu.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ChangePause();
        }


    }

    void ChangePause(){

        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0f; 
            pauseMenu.SetActive(true);
        }
        else
        {
            Time.timeScale = 1f; 
            pauseMenu.SetActive(false);

        }
    }
}

