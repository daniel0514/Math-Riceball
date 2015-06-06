using UnityEngine;
using System.Collections;

public class DivideRiceHandler : OperatorHandler {
    string op;
    protected override void Start()
    {
        base.Start();
        op = "/";
    }

}
