using UnityEngine;
using System.Collections;

public class DivideRiceHandler : OperatorHandler {
    protected override void Start()
    {
        base.Start();
        base.op = "/";
    }

}
