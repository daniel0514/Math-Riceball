using UnityEngine;
using System.Collections;

public class MultRiceHandler : OperatorHandler {
    protected override void Start()
    {
        base.Start();
        base.op = "*";
    }

}
