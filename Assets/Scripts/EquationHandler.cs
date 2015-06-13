using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EquationHandler : MonoBehaviour {
    bool showEquation = false;
    Text equationText;
	// Use this for initialization
	void Start () {
        equationText = GetComponent<Text>();
	    if(showEquation == false)
        {
            equationText.enabled = false;
        } else
        {
            equationText.enabled = true;
        }
	}
	
	// Update is called once per frame
	void Update () {
        equationText.text = ResultAndOpsHandler.equation;
	}
}
