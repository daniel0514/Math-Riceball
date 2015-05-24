using UnityEngine;
using System.Collections;

public class MinusHandler : MonoBehaviour{
    string op;
    // Use this for initialization
    void Start()
    {
        op = "-"
        this.transform.position = Vector3.up * 2.0f * Random.Range(-1.0f, 1.0f) + Vector3.right * 10.0f;
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
        string op = PlayerPrefs.GetString("op");
        if(op == null)
        {
            switch (op)
            {
            PlayerPrefs.SetString("op", null);
        } else
        {
            //Load End Game Screen;
        }
        Destroy(this.gameObject);
    }
}
