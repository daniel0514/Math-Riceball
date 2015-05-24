using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimerHandler : MonoBehaviour
{

    static float timer = 10f;
    public Text text_box;
    public GameObject endMenu;

    // Use this for initialization
    void Start()
    {
        timer = 15.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        text_box.text = timer.ToString("0.0");

        if (timer <= 0)
        {
            Time.timeScale = 0.0f;
            endMenu.SetActive(true);
        }
    }

}

