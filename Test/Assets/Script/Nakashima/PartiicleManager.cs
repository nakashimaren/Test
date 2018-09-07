using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class ParticleManager
{

    /// <summary>
    /// プール用オブジェクトのリスト
    /// </summary>
    private static List<ParticlePooler> particlePoolerList = new List<ParticlePooler>();

    /// <summary>
    /// 指定した名前のパーティクル再生
    /// 	初めて再生するパーティクルはプール用オブジェクトを生成
    /// </summary>
    /// <param name="particleName">Particle name.</param>
    /// <param name="position">Position.</param>
    public static void PlayParticle(string particleName, Vector3 position)
    {
        //リストから指定した名前のプール用オブジェクトを取得
        ParticlePooler pooler = particlePoolerList.Where(tempPooler => tempPooler.ParticleName == particleName).FirstOrDefault();
        if (pooler == null)
        {
            //取得できなければ新たに生成
            pooler = new ParticlePooler(particleName);
            particlePoolerList.Add(pooler);
        }
        pooler.Play(position);
    }
}
