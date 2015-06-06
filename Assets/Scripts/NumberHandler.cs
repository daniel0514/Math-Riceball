using UnityEngine;
using System.Collections;

public class NumberHandler : MonsterHandler
{
    protected int value;
    public GameObject canvas_menu = null;

    // Use this for initialization
    protected override void Start() {
        base.Start();
        Debug.Log("Number is " + value);
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
                    if(value == 0)
                    {
                        canvas_menu.SetActive(true);
                        Time.timeScale = 0.0f;
                        Debug.Log("EndGame");
                        break;
                    } else
                    {
                        result /= value;
                        break;
                    }
                default:
                    break;
            }
            ResultAndOpsHandler.ops = null;
            ResultAndOpsHandler.result = result;
        }
        else
        {
            //Load End Game Screen;
            canvas_menu.SetActive(true);
            Time.timeScale = 0.0f;
        }
        Debug.Log("Result is : " + ResultAndOpsHandler.result + "\nOperator is : " + ResultAndOpsHandler.ops);
        Destroy(this.gameObject);
    }
}
