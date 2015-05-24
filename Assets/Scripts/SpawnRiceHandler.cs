using UnityEngine;
using System.Collections;

public class SpawnRiceHandler : MonoBehaviour {
    float spawnTimer = 0.0f;
    public float timeBetweenRice = 1.5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        spawnTimer -= Time.deltaTime;
	}
}
