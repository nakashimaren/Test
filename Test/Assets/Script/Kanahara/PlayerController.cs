using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    // このスクリプトで使う変数一覧
    private CharacterController charaCon;       // キャラクターコンポーネント用の変数
    //private Animator animCon;  //  アニメーションするための変数
    public float _speed = 5.0f;         // 移動速度（Public＝インスペクタで調整可能）
    private float _lowerSpeed;      //下限速度
    public float kaitenSpeed = 1200.0f;   // プレイヤーの回転速度（Public＝インスペクタで調整可能）

    public float _acceleration = 0.1f;   // プレイヤーの回転速度（Public＝インスペクタで調整可能）

    public　GameObject _timerObject; //タイマーオブジェクト
    private Timer _timer;   //タイマー変数

    // ■最初に1回だけ実行する処理
    void Start()
    {
        charaCon = GetComponent<CharacterController>(); // キャラクターコントローラーのコンポーネントを参照する
        //animCon = GetComponent<Animator>(); // アニメーターのコンポーネントを参照する

        //下限速度の初期化
        _lowerSpeed = _speed;

        //Timer変数取得
        _timer = _timerObject.GetComponent<Timer>();
    }


    // ■毎フレーム常に実行する処理
    void Update()
    {
        if (_timer._timeLimit > 0)
        {
            // ▼▼▼移動処理▼▼▼
            if (Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal") == 0)  //  テンキーや3Dスティックの入力（GetAxis）がゼロの時の動作
            {
                // animCon.SetBool("Run", false);  //  Runモーションしない
            }
            else //  テンキーや3Dスティックの入力（GetAxis）がゼロではない時の動作
            {
                var cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;  //  カメラが追従するための動作
                Vector3 direction = cameraForward * Input.GetAxis("Vertical") + Camera.main.transform.right * Input.GetAxis("Horizontal");  //  テンキーや3Dスティックの入力（GetAxis）があるとdirectionに値を返す
                                                                                                                                            //animCon.SetBool("Run", true);  //  Runモーションする

                MukiWoKaeru(direction);  //  向きを変える動作の処理を実行する（後述）
                IdoSuru(direction);  //  移動する動作の処理を実行する（後述）
            }

            //ボタンを押している間加速する
            if (Input.GetButton("Action1") || Input.GetKey(KeyCode.Space))
            {
                _speed += _acceleration;
            }
            else
            {
                _speed -= _acceleration;

                if (_lowerSpeed >= _speed)
                {
                    _speed = _lowerSpeed;
                }
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.Return))
            {
                SceneManager.LoadScene("Title");
            }
            if (Input.GetKeyDown("joystick button 0"))
            {
                SceneManager.LoadScene("Title");
            }
            if (Input.GetKeyDown("joystick button 1"))
            {
                SceneManager.LoadScene("Title");
            }
            if (Input.GetKeyDown("joystick button 2"))
            {
                SceneManager.LoadScene("Title");
            }
            if (Input.GetKeyDown("joystick button 3"))
            {
                SceneManager.LoadScene("Title");
            }
            if (Input.GetKeyDown("joystick button 4"))
            {
                SceneManager.LoadScene("Title");
            }
            if (Input.GetKeyDown("joystick button 5"))
            {
                SceneManager.LoadScene("Title");
            }
            if (Input.GetKeyDown("joystick button 6"))
            {
                SceneManager.LoadScene("Title");
            }
            if (Input.GetKeyDown("joystick button 7"))
            {
                SceneManager.LoadScene("Title");
            }
            if (Input.GetKeyDown("joystick button 8"))
            {
                SceneManager.LoadScene("Title");
            }
            if (Input.GetKeyDown("joystick button 9"))
            {
                SceneManager.LoadScene("Title");
            }
        }
    }


    // ■向きを変える動作の処理
    void MukiWoKaeru(Vector3 mukitaiHoukou)
    {
        Quaternion q = Quaternion.LookRotation(mukitaiHoukou);          // 向きたい方角をQuaternion型に直す
        transform.rotation = Quaternion.RotateTowards(transform.rotation, q, kaitenSpeed * Time.deltaTime);   // 向きを q に向けてじわ～っと変化させる.
    }


    // ■移動する動作の処理
    void IdoSuru(Vector3 idosuruKyori)
    {
        charaCon.Move(idosuruKyori * Time.deltaTime * _speed);   // プレイヤーの移動距離は時間×移動スピードの値
    }
}


