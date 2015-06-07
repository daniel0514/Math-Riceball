using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SushiHandler : MonoBehaviour {

    public GameObject menu;
    public static GameObject canvas_menu;
    Rigidbody2D _Rigidbody2D;
    // Use this for initialization
    void Start()
    {
        _Rigidbody2D = this.GetComponent<Rigidbody2D>();
        canvas_menu = menu;
    }
    

    // Update is called once per frame
    void Update () {
        
        if (Input.GetKeyDown("space")||Input.GetMouseButtonDown(0))
        {

           _Rigidbody2D.velocity = Vector2.zero;
            _Rigidbody2D.AddForce(Vector2.up* 10.0f, ForceMode2D.Impulse);
        }

        _Rigidbody2D.rotation = _Rigidbody2D.velocity.y * 2.0f;
    }
    void OnBecameInvisible()
    {
        //If there is a remaining number, update the result with it before you go to the end screen.
        int last_num = ResultAndOpsHandler.last_num;
        string last_op = ResultAndOpsHandler.last_op;
        int result = ResultAndOpsHandler.result;

        if (last_num != -1)
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
        }


        Time.timeScale = 0.0f;
        menu.SetActive(true);
        Debug.Log("Result is : " + ResultAndOpsHandler.result + "\nlast_op is : " + ResultAndOpsHandler.last_op + "\nlast_num is : " + ResultAndOpsHandler.last_num);

    }


}
