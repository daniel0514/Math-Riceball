using UnityEngine;
using System.Collections;

public class CurrentOperator : MonoBehaviour {

    SpriteRenderer op;
    public Sprite[] ops;

	// Use this for initialization
	void Start () {
        op = this.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {

        string last_op = ResultAndOpsHandler.last_op;

        switch (last_op)
        {
            case "+":
                if (OperatorHandler.firstAddition)
                    op.sprite = null;
                else
                    op.sprite = ops[0];
                break;
            case "-":
                op.sprite = ops[1];
                break;
            case "*":
                op.sprite = ops[2];
                break;
            case "/":
                op.sprite = ops[3];
                break;
            case "":
                op.sprite = null;
                break;
        }

	}
}
