using UnityEngine;
using System.Collections;

public class PlusRiceHandler : MonoBehaviour {
    string op;
    void Start()
    {
        op = "+";
        this.transform.position = Vector3.up * 2.0f * Random.Range(-1.0f, 1.0f) + Vector3.right * 20.0f;
    }

    // Update is called once per frame
    void Update () {
        this.transform.position -= Vector3.right * 3.0f * Time.deltaTime;
        if (this.transform.position.x <= -32.0f)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D()
    {
        string cur_op = ResultAndOpsHandler.ops;

        if (cur_op != null)
        {
             //EndGame();
        }
        else if (cur_op == null)
        {
            ResultAndOpsHandler.ops = op;
        }
        Debug.Log("Result is : " + ResultAndOpsHandler.result + "\nOperator is : " + ResultAndOpsHandler.ops);

        Destroy(this.gameObject);

    }
}
