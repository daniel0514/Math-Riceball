using UnityEngine;
using System.Collections;

public class MinusRiceHandler : OperatorHandler {
    protected override void Start()
    {
        base.Start();
        base.op = "-";
    }

}
