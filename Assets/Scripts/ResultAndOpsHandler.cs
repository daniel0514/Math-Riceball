using UnityEngine;
using System.Collections;

public class ResultAndOpsHandler : MonoBehaviour {
    public static int result;
    public static string ops;

    /*
    public int getResult()
    {
        return result;
    }
    
    public void setResult(int r)
    {
        result = r;
    }

    public string getOps()
    {
        return ops;
    }

    public void setOps(string ops)
    {
        this.ops = ops;
    }
    */

	// Use this for initialization
	void Start () {
        result = 0;
        ops = "+";
        Debug.Log("Result is : " + ResultAndOpsHandler.result + "\nOperator is : " + ResultAndOpsHandler.ops);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
