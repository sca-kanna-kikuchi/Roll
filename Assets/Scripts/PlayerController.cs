using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;//動く速さ
    public Text scoreText;
    public Text winText;

    //以下１行追加(2023/4/28)
    public float jumpSpeed;


    private Rigidbody rb;//Rigidbody
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        //Rigidbodyを取得
        rb = GetComponent<Rigidbody>();

        score = 0;
        SetCountText();
        winText.text = "";//何も表示しないことを示している

    }

    // Update is called once per frame
    void Update()
    {
        //以下テスト出るかもしれない
        //カーソルキーの入力を取得
        //varは型推論？→intとかfloatとかわかんなくなる人の救済措置→右辺の内容から型を考えてくれる
        //varを使うときは右辺を省略するとバグる
        var moveHorizontal = Input.GetAxis("Horizontal");//Horizontalは水平
        var moveVertical = Input.GetAxis("Vertical");

        //カーソルキーの入力に合わせて移動方向を設定
        var movement=new Vector3(moveHorizontal,0,moveVertical);

        //Rigidbodyに力を与えて球を動かす
        //movement→方向、ベクトル
        rb.AddForce(movement*speed);

        if (transform.position.y < -10)
        {
            SceneManager.LoadScene("Roll a ball");
        }else if (transform.position.y > 150)
        {
            SceneManager.LoadScene("Roll a ball");
        }
        /*
        //以下４行追加(2023/4/28)
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity=Vector3.up*jumpSpeed;
        }
        */
    }

    void OnTriggerEnter(Collider other)//「すり抜ける時に使うのは？」→「オントリガーエンター」
    {
        if(other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);

            score = score + 1;

            SetCountText();
        }
    }

    void SetCountText()
    {
        scoreText.text = "Count:"+score.ToString();

        if (score >= 5)
        {
            winText.text = "You Win!";
        }
    }


}
