﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoupleDestroy : MonoBehaviour {

    HitStopCoupleDamage hitStopCoupleDamage;
    EnemyPop enemyPop;
    float span = 3.0f;
    
    // Use this for initialization
    void Start () {
        hitStopCoupleDamage = GetComponent<HitStopCoupleDamage>();
        enemyPop = GetComponent<EnemyPop>();
        StartCoroutine("Time");
    }
	
	// Update is called once per frame
	void Update () {

	}
    private IEnumerator Time()
    {
        while (true)
        {
            if (hitStopCoupleDamage.GetFlag())
            {
                //if (!(GetComponent<Renderer>().isVisible))
                //{
                     EffekseerHandle handle = EffekseerSystem.PlayEffect("Burst", transform.position);
               // }
                yield return new WaitForSeconds(span);
                hitStopCoupleDamage.SetFlag(false);
                Destroy(transform.parent.gameObject);
                enemyPop.Pop();

            }
            yield return new WaitForSeconds(0.1f);
        }


    }
}

