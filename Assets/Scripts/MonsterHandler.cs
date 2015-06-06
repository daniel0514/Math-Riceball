using UnityEngine;
using System.Collections;

public class MonsterHandler : MonoBehaviour {
    // Use this for initialization
    protected virtual void Start () {
        this.transform.position = Vector3.up * 2.0f * Random.Range(-1.0f, 1.0f) + Vector3.right * 20.0f;
    }
	
	// Update is called once per frame
	protected virtual void Update () {
        this.transform.position -= Vector3.right * 3.0f * Time.deltaTime;
        if (this.transform.position.x <= -32.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
