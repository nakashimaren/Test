using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitStopCoupleDamage : MonoBehaviour
{

    [SerializeField]
    private GameObject damagePrefab;
    [SerializeField]
    private TimeManager timeManager;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {

            var damageParticle = GameObject.Instantiate(damagePrefab, col.ClosestPointOnBounds(col.transform.position), Quaternion.identity) as GameObject;

            //　全体のタイムスケールを変更する
            timeManager.SlowDown();
        }
    }
}
