using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitStopCoupleDamage : MonoBehaviour
{

    [SerializeField]
    private GameObject damagePrefab;
    [SerializeField]
    private TimeManager timeManager;
    [SerializeField]
    private AudioClip audioClip1;
    private AudioSource audioSource;
    private HitStopSlowAnim hitStopSlowAnim;
    private void Start()
    {
        hitStopSlowAnim = GetComponent<HitStopSlowAnim>();
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

            //audioSource = gameObject.GetComponent<AudioSource>();
            //audioSource.clip = audioClip1;
            //audioSource.Play();
        }
    }
}
