using UnityEngine;
using System.Collections;

public class MultRiceHandler : OperatorHandler {
    string op;
    protected override void Start()
    {
        op = "*";
        this.transform.position = Vector3.up * 2.0f * Random.Range(-1.0f, 1.0f) + Vector3.right * 20.0f;
    }

}
