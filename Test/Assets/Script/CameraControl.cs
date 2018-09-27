using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    private Vector3 _rot;

    public Vector3 _speed;
    public float _accel;

    // Use this for initialization
    void Start () {
        _rot = new Vector3(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("RButton"))
        {
            Debug.Log("Rpush");
            //transform.Rotate(_speed);
            _rot += _speed;
        }

        if (Input.GetButton("LButton"))
        {
            Debug.Log("Lpush");
            _rot -= _speed;

        }

        Quaternion q = Quaternion.Euler(_rot);       // 向きたい方角をQuaternion型に直す
        transform.rotation = Quaternion.RotateTowards(transform.rotation, q, _accel * Time.deltaTime);   // 向きを q に向けてじわ～っと変化させる.

    }
}
