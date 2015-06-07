using UnityEngine;
using System.Collections;

public class OperatorHandler : MonsterHandler
{
    protected string op;
    public GameObject canvas_menu = null;
    // Use this for initialization
    protected override void Start()
    {
        base.Start();
    }

    protected virtual void OnCollisionEnter2D()
    {
        if (canvas_menu == null)
        {
            canvas_menu = SushiHandler.canvas_menu;
        }
        string last_op = ResultAndOpsHandler.last_op;
        int last_num = ResultAndOpsHandler.last_num;
        int result = ResultAndOpsHandler.result;

        if (last_num == -1) //if there is no last_num, replace the last operator with the one you just hit
        {
            ResultAndOpsHandler.last_op = op;
        }
        else //if there is a last_num, update the result, set last_op to the op, and set last_num to -1
        {
            switch (last_op)
            {
                case "+":
                    ResultAndOpsHandler.equation = "(" + ResultAndOpsHandler.equation + " + " + last_num + ")";
                    result += last_num;
                    break;
                case "-":
                    ResultAndOpsHandler.equation = "(" + ResultAndOpsHandler.equation + " - " + last_num + ")";
                    result -= last_num;
                    break;
                case "*":
                    ResultAndOpsHandler.equation = "(" + ResultAndOpsHandler.equation + " * " + last_num + ")";
                    result *= last_num;
                    break;
                case "/":
                    ResultAndOpsHandler.equation = "(" + ResultAndOpsHandler.equation + " / " + last_num + ")";
                    //divide by zero is handled in NumberHandler
                    result /= last_num;
                    break;
            }
            Debug.Log("Equation is " + ResultAndOpsHandler.equation);

            ResultAndOpsHandler.result = result;
            ResultAndOpsHandler.last_op = op;
            ResultAndOpsHandler.last_num = -1;
        }

        Debug.Log("Result is : " + ResultAndOpsHandler.result + "\nlast_op is : " + ResultAndOpsHandler.last_op + "\nlast_num is : " + ResultAndOpsHandler.last_num);

        Destroy(this.gameObject);

    }
}

