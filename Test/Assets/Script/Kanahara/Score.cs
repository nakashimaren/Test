using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    //制限時間
    public int _score;

    //UI
    public Image num1;
    public Image num2;
    public Image num3;
    public Image num4;

    //
    private HitStopCoupleDamage _hitStopCoupleDamage;

    public Sprite[] number;

    // Use this for initialization
    void Start () {
        _hitStopCoupleDamage = GetComponent<HitStopCoupleDamage>();
	}
	
	// Update is called once per frame
	void Update () {

        if (_hitStopCoupleDamage.GetFlag())
        {
            Add(20);
        }

        int score = _score;

        //Debug.Log(score.ToString());
        
        int val4 = (int)score / 1000;
        score -= val4 * 1000;

        int val3 = (int)score / 100;
        score -= val3 * 100;

        int val2 = (int)score / 10;
        int val1 = (int)score % 10;

        //Debug.Log(val4.ToString());

        num1.sprite = number[val1];
        num2.sprite = number[val2];
        num3.sprite = number[val3];
        num4.sprite = number[val4];

    }

    public void Add(int val)
    {
        _score += val;
    }
}
