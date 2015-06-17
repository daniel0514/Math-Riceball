using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
     Button startText;

    void Start()
    {
        startText = this.startText.GetComponent<Button>();
    }
    void Update()
    {
        /*
            const int buttonWidth = 190;
            const int buttonHeight = 53;

            // Determine the button's place on screen
            // Center in X, 2/3 of the height in Y
            Rect buttonRect = new Rect(
                  // Screen.width / 2 - (buttonWidth / 2),
                  //(2 * Screen.height / 3) - (buttonHeight / 2),
                  410,
                  130,
                  buttonWidth,
                  buttonHeight
                );

            // Draw a button to start the game
            if (GUI.Button(buttonRect, ""))
            {
                // On Click, load the first level.
                // "Stage1" is the name of the first scene we created.
                Application.LoadLevel("background");
                */
      
    }

    public void startLevel()
    {
        Application.LoadLevel("background");
    }
}
