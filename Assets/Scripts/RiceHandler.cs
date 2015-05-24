using UnityEngine;
using System.Collections;

public class RiceHandler : MonoBehaviour{
    
    // Use this for initialization
    void Start()
    {
        this.transform.position = Vector3.up * 2.0f * Random.Range(-1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update () {
        this.transform.position -= Vector3.right * 7.0f * Time.deltaTime;
        if(this.transform.position.x <= -32.0f)
        {
            Destroy(this.gameObject);
        }
	}
}
