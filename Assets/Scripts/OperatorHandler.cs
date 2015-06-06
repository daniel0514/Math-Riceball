using UnityEngine;
using System.Collections;

public class OperatorHandler : MonsterHandler
{
    protected string op;
    public GameObject canvas_menu = null;
    // Use this for initialization
    protected override void Start () {
        base.Start();
    }

    protected virtual void OnCollisionEnter2D()
    {
        if (canvas_menu == null)
        {
            canvas_menu = SushiHandler.canvas_menu;
        }
        string cur_op = ResultAndOpsHandler.ops;

        if (cur_op != null)
        {
            //EndGame();
            canvas_menu.SetActive(true);
            Time.timeScale = 0.0f;
        }
        else if (cur_op == null)
        {
            ResultAndOpsHandler.ops = op;
        }
        Debug.Log("Result is : " + ResultAndOpsHandler.result + "\nOperator is : " + ResultAndOpsHandler.ops);

        Destroy(this.gameObject);

    }
}
