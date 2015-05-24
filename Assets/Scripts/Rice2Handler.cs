﻿using UnityEngine;
using System.Collections;

public class Rice2Handler : MonoBehaviour{
    int value;
    // Use this for initialization
    void Start()
    {
        value = 2;
        this.transform.position = Vector3.up * 2.0f * Random.Range(-1.0f, 1.0f) + Vector3.right * 20.0f;
    }

    // Update is called once per frame
    void Update () {
        this.transform.position -= Vector3.right * 3.0f * Time.deltaTime;
        if(this.transform.position.x <= -32.0f)
        {
            Destroy(this.gameObject);
        }
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        int result = PlayerPrefs.GetInt("result");
        string op = PlayerPrefs.GetString("op");
        Debug.Log("OPS previous result is " + result);
        Debug.Log("OPS previous op is " + op);
        if (op != null)
        {
            switch (op)
            {
                case "+":
                    result += value;
                    break;
                case "-":
                    result -= value;
                    break;
                case "*":
                    result *= value;
                    break;
                case "/":
                    result /= value;
                    break;
                default:
                    break;
            }
            PlayerPrefs.SetInt("result", result);
            PlayerPrefs.SetString("op", null);
        } else
        {
            //Load End Game Screen;
        }
        Destroy(this.gameObject);
    }
}
