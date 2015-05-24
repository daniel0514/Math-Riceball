using UnityEngine;
using System.Collections;

public class SpawnRiceHandler : MonoBehaviour {
   // public GameObject[] rice_types;
    float spawnTimer = 0.0f;
    public float timeBetweenRice = 1.5f;
    public GameObject[] rice_types;


	// Use this for initialization
	void Start () {
 
    }
	
	// Update is called once per frame
	void Update () {
        spawnTimer -= Time.deltaTime;
        if(spawnTimer < 0.0f)
        {
            spawnTimer = timeBetweenRice;
            int i = Random.Range(0, rice_types.Length);
            Instantiate(rice_types[i], Vector3.right * 20f, Quaternion.identity);
        }
	}
}
