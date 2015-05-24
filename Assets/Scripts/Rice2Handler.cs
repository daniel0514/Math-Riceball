using UnityEngine;
using System.Collections;

public class Rice2Handler : MonoBehaviour{
    int value;
    public GameObject canvas_menu = null;
    // Use this for initialization
    void Start()
    {
        value = 2;
        this.transform.position = Vector3.up * 2.0f * Random.Range(-1.0f, 1.0f) + Vector3.right * 20.0f;
    }

    // Update is called once per frame
    void Update () {
        this.transform.position -= Vector3.right * 3.0f * Time.deltaTime;
        if(this.transform.position.x <= -32.0f)
        {
            Destroy(this.gameObject);
        }
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
