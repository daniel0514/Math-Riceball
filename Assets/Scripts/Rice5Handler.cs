using UnityEngine;
using System.Collections;

public class Rice5Handler : MonsterHandler{
    int value;
    public GameObject canvas_menu = null;
    // Use this for initialization
    protected override void Start()
    {
        base.Start();
        value = 5;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (canvas_menu == null)
        {
            canvas_menu = SushiHandler.canvas_menu;
        }
        int result = ResultAndOpsHandler.result;
        string op = ResultAndOpsHandler.ops;
        if (op != null)
        {
            switch (op)
            {
                case "+":
                    result += value;
                    break;
                case "-":
                    result -= value;
                    break;
                case "*":
                    result *= value;
                    break;
                case "/":
                    result /= value;
                    break;
                default:
                    break;
            }
            ResultAndOpsHandler.ops = null;
            ResultAndOpsHandler.result = result;
        } else
        {
            //Load End Game Screen;
            canvas_menu.SetActive(true);
            Time.timeScale = 0.0f;
        }
        Debug.Log("Result is : " + ResultAndOpsHandler.result + "\nOperator is : " + ResultAndOpsHandler.ops);
        Destroy(this.gameObject);
    }
}
