using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPop : MonoBehaviour {

    //popplaceのpositionを格納
    private List<Vector3> _positions;

    //生成するカップルprefab
    public GameObject _couplePrefab;

    private bool _popFlag = true;


    // Use this for initialization
    void Start () {

        //初期化
        _positions = new List<Vector3>(); ;

        //Geme内のpopplaceのタグのobjectを取得
        GameObject[] popplace = GameObject.FindGameObjectsWithTag("popplace");

        //listを初期化
        for (int i = 0; i < popplace.Length; i++)
        {
            //Debug.Log(popplace[i].transform.position.ToString());
            _positions.Add(popplace[i].transform.position);
        }

        //最初の一組目を生成
        Pop();

    }
	
	// Update is called once per frame
	void Update ()
    {


	}

    //カップル生成
    public void Pop()
    {
        //popする場所の決定
        int num = Random.Range(0, _positions.Count);

        //Debug.Log(num.ToString());

        //角度生成
        Quaternion q = new Quaternion();
        q = Quaternion.identity;

        //生成
        Instantiate(_couplePrefab,_positions[num],q);
    }
}
