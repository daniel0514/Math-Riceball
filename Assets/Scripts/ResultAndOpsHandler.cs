using UnityEngine;
using System.Collections;

public class ResultAndOpsHandler : MonoBehaviour {
    public static int result;
    public static string last_op;
    public static int last_num = -1;
    public static string equation;
    public static bool bDivByzero = bDivByzero;
    public static bool showEquation = false;


    // Use this for initialization
    void Start () {
        result = 0;
        last_op = "";
        last_num = -1; //use -1 to mean "last_num is empty"
        equation = "";
        Debug.Log("Result is : " + ResultAndOpsHandler.result + "\nlast_op is : " + ResultAndOpsHandler.last_op + "\nlast_num is : " + ResultAndOpsHandler.last_num);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
