﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Timer : MonoBehaviour {

    //制限時間
    public float _timeLimit;

    //UI
    public Image time;
    public Image time2;
    public Sprite[] number;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        _timeLimit -= Time.deltaTime;

        int val = (int)_timeLimit / 10;
        int val2 = (int)_timeLimit % 10;

        time.sprite = number[val];
        time2.sprite = number[val2];

        if (_timeLimit <= 0)
        {

        }
	}
}