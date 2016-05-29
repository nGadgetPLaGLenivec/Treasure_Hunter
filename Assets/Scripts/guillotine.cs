using UnityEngine;
using System.Collections;

public class guillotine : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.eulerAngles = new Vector3(0, 0, Mathf.PingPong(Time.time * 50, 360));
	}
}
