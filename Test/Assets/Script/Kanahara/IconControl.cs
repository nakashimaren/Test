using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconControl : MonoBehaviour {

    Vector3 _var;
    public GameObject _parent;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        _var = _parent.transform.position;
        _var.y = transform.position.y;
        transform.position = _var;


    }
}
