using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SushiHandler : MonoBehaviour {

    Rigidbody2D _Rigidbody2D;
    // Use this for initialization
    void Start()
    {
        PlayerPrefs.SetInt("result", 0);
        PlayerPrefs.SetString("op", null);
        _Rigidbody2D = this.GetComponent<Rigidbody2D>();
    }
    

    // Update is called once per frame
    void Update () {
        
        if (Input.GetMouseButtonDown(0))
        {

           _Rigidbody2D.velocity = Vector2.zero;
            _Rigidbody2D.AddForce(Vector2.up* 10.0f, ForceMode2D.Impulse);
        }

        _Rigidbody2D.rotation = _Rigidbody2D.velocity.y * 2.0f;
    }


}
