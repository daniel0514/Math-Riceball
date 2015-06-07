﻿using UnityEngine;
using System.Collections;

public class InputHandler : MonoBehaviour {

    public string userInput;
    public UnityEngine.UI.InputField inputField;
    public UnityEngine.UI.Text textDisplay;
    public GameObject WinMenu;
    public GameObject LoseMenu;
    public GameObject _inputfieldCanvas;
    public GameObject score;


    void LockInput(UnityEngine.UI.InputField input)
    {
        if (input.text.Length > 0)
        {
            if (input.text.Equals(ResultAndOpsHandler.result.ToString()))
            {
                _inputfieldCanvas.SetActive(false);
                WinMenu.SetActive(true);
                Debug.Log("==");
                //score.GetComponent<GUIText>() = ResultAndOpsHandler.result.ToString();
            }
            else
            {
                //inputField.gameObject.SetActive(false);
                //inputField.gameObject.SetActive(false);
                // inputField.gameObject.GetComponent<Renderer>().enabled = false;
                _inputfieldCanvas.SetActive(false);
                LoseMenu.SetActive(true);
                Debug.Log("wrong number entered");
            }    
                    
                    
             Debug.Log("Text has been entered");
        }
       
    }


    void Start()
    {
        inputField.onEndEdit.AddListener(delegate { LockInput(inputField); });
    }
    // Update is called once per frame
    void Update () {
        userInput = inputField.text;
        //Debug.Log("userinput entered");
        textDisplay.text = userInput;
    }
}
