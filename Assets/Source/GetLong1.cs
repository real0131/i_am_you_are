using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GetLong1 : MonoBehaviour {
    public GameObject obj;
    public GameObject player;
    public Text text;
	// Use this for initialization
	void Start () {
        Debug.Log("hello");
	}
	
	// Update is called once per frame
	void Update () {
        float distance = Vector2.Distance(obj.transform.position, player.transform.position);
        
        distance = (int)(distance * 10);
        text.text = "남은거리:" + distance.ToString();
	}
}
