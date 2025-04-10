using UnityEngine;

public class PauseManager : MonoBehaviour
{
    private bool isPaused = false;
    public GameObject pause;
    private void Start()
    {
        pause.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();
        }
    }

    void TogglePause()
    {
        if (isPaused)
        {
            Time.timeScale = 1f;  // Resume
            isPaused = false;
            pause.SetActive(false);
        }
        else
        {
            Time.timeScale = 0f;  // Pause
            isPaused = true;
            pause.SetActive(true);
        }

    }
}
