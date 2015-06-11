using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour {
    Text scoreText;
	// Use this for initialization
	void Start () {
        Debug.Log("In Scorehandler");
        scoreText = GetComponent<Text>();
        if(scoreText != null)
        {
            Debug.Log("is not NULL");
        }
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = ResultAndOpsHandler.result.ToString();
	}
}
