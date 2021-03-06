﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitStopCoupleDamage : MonoBehaviour
{

    [SerializeField]
    private GameObject damagePrefab;
    [SerializeField]
    private TimeManager timeManager;
    
    public AudioClip audioClip1;
    private AudioSource audioSource;
    private HitStopSlowAnim hitStopSlowAnim;
    private bool HitFlag = false;
    private void Start()
    {
        hitStopSlowAnim = GetComponent<HitStopSlowAnim>();
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip1;
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {

            var damageParticle = GameObject.Instantiate(damagePrefab, col.ClosestPointOnBounds(transform.TransformPoint(col.transform.position)), Quaternion.identity) as GameObject;

            //　全体のタイムスケールを変更する
            //  timeManager.SlowDown();

            damageParticle.GetComponent<HItStopSlowParticle>().SlowDown();

            //　個々のAnimatorのスピードを変更する場合
            var playerSlowAnim = col.GetComponentInParent<HitStopSlowAnim>();
            if (!playerSlowAnim.IsSlowDown())
            {
                playerSlowAnim.SlowDown();
            }
            if (!hitStopSlowAnim.IsSlowDown())
            {
                hitStopSlowAnim.SlowDown();
            }
            HitFlag = true;
           
            audioSource.Play();
        }
    }
    public bool GetFlag()
    {
        return HitFlag;
    }
    public void SetFlag(bool flag)
    {
        HitFlag = flag;
    }

}
