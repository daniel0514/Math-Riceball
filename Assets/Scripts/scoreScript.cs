using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scoreScript : MonoBehaviour {
    public Text score;
    // Use this for initialization
    void Start () {
        score.text = "You won! Your score is:" + ResultAndOpsHandler.result;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
