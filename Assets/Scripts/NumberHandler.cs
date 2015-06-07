using UnityEngine;
using System.Collections;

public class NumberHandler : MonsterHandler
{
    protected int value;
    public GameObject canvas_menu = null;

    // Use this for initialization
    protected override void Start() {
        base.Start();
    }
	
    void OnCollisionEnter2D(Collision2D other)
    {
        if (canvas_menu == null)
        {
            canvas_menu = SushiHandler.canvas_menu;
        }

        if (ResultAndOpsHandler.last_op == "")
        {
            ResultAndOpsHandler.last_op = "+";
            ResultAndOpsHandler.last_num = value;
        }

        //End game if you divide by zero

        if (ResultAndOpsHandler.last_op == "/" && value == 0)
        {
            canvas_menu.SetActive(true);
            Time.timeScale = 0.0f;
            Debug.Log("EndGame");
        }


        ResultAndOpsHandler.last_num = value;

        Debug.Log("Result is : " + ResultAndOpsHandler.result + "\nlast_op is : " + ResultAndOpsHandler.last_op + "\nlast_num is : " + ResultAndOpsHandler.last_num);

        Destroy(this.gameObject);
    }
}
