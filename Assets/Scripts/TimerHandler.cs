using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimerHandler : MonoBehaviour
{

    static float timer = 60.00f;
    public Text text_box;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        text_box.text = timer.ToString("0");

        if (timer == 0)
        {
            //endGame();
        }
    }

}

