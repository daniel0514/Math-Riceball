using UnityEngine;
using System.Collections;

public class GroundHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        //move ground 3 units per second
        this.transform.position -= Vector3.right * 3.0f * Time.deltaTime;

        //ground looping
        if(this.transform.position.x <= -39.95f)
        {
            this.transform.position = Vector3.right * 39.95f;
        }
	}
}
