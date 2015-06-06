using UnityEngine;
using System.Collections;

public class MultRiceHandler : OperatorHandler {
    string op;
    protected override void Start()
    {
        base.Start();
        base.op = "*";
    }

}
