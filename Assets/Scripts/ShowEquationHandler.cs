using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowEquationHandler : MonoBehaviour {
    Toggle showEquation;
	// Use this for initialization
	void Start () {
        showEquation = GetComponent<Toggle>();
        if(showEquation != null)
        {
            showEquation.isOn = false;
        } 
	}
	
	// Update is called once per frame
	void Update () {
	    if(showEquation.isOn == true && ResultAndOpsHandler.showEquation == false)
        {
            Debug.Log("Change Euqation on");
            ResultAndOpsHandler.showEquation = true;
        } else if (showEquation.isOn == false && ResultAndOpsHandler.showEquation == true)
        {
            Debug.Log("Change Euqation Off");
            ResultAndOpsHandler.showEquation = false;
        }
	}
}
