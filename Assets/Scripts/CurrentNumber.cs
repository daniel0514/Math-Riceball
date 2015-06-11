using UnityEngine;
using System.Collections;

public class CurrentNumber : MonoBehaviour {

    SpriteRenderer number;
    public Sprite[] numbers;
	// Use this for initialization
	void Start () {
        number = this.GetComponent<SpriteRenderer>();
        //numbers = new Sprite[10];
	}
	
	// Update is called once per frame
	void Update () {
        int last_num = ResultAndOpsHandler.last_num;
        if (last_num == -1)
            number.sprite = null;
        else
            number.sprite = numbers[last_num];
    }
}
