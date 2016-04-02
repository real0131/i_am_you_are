using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Move : MonoBehaviour {
    public float speed = 1.5f;
    public Button button;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed*Time.deltaTime);
             
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(-1*Vector2.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(-1 * Vector2.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
    }
    public void onClick()
    {
        Debug.Log(button.GetInstanceID());
    }
}
