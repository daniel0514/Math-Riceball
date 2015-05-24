using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

    public bool paused = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            paused = togglePause();
        }
	}

    void onGUI ()
    {
        if (paused)
        {
            GUILayout.Label("Game is paused!");
            if (GUILayout.Button("Click me to unpause"))
            {
                paused = togglePause();
            }
        }
    }
    bool togglePause()
    {
        if (Time.timeScale == 0.0f)
        {
            Time.timeScale = 1.0f;
            return (false);
        } else
        {
            Time.timeScale = 0.0f;
            return (true);
        }
    }

    public void Restart()
    {
        //Application.LoadLevel(0);
        Application.LoadLevel(Application.loadedLevel);
        Time.timeScale = 1.0f;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
