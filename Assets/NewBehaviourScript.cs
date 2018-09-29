using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Vector3 pos = new Vector3(0, 0, 0);
        transform.position = pos;
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKey("a"))
        {
            transform.position = new Vector3(1, 1, 1);
        }
		
	}
}
