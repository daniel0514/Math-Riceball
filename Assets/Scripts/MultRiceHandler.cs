using UnityEngine;
using System.Collections;

public class MultRiceHandler : MonoBehaviour {

    void Start()
    {
        this.transform.position = Vector3.up * 2.0f * Random.Range(-1.0f, 1.0f) + Vector3.right * 13.0f;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position -= Vector3.right * 3.0f * Time.deltaTime;
        if (this.transform.position.x <= -32.0f)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D()
    {
        string cur_op = PlayerPrefs.GetString("op");

        if (cur_op != null)
        {
            //EndGame();
        }
        else if (cur_op == null)
        {
            PlayerPrefs.SetString("op", "*");
        }

        Destroy(this.gameObject);

    }
}
