using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;//��������
    public Text scoreText;
    public Text winText;

    //�ȉ��P�s�ǉ�(2023/4/28)
    public float jumpSpeed;


    private Rigidbody rb;//Rigidbody
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody���擾
        rb = GetComponent<Rigidbody>();

        score = 0;
        SetCountText();
        winText.text = "";//�����\�����Ȃ����Ƃ������Ă���

    }

    // Update is called once per frame
    void Update()
    {
        //�ȉ��e�X�g�o�邩������Ȃ�
        //�J�[�\���L�[�̓��͂��擾
        //var�͌^���_�H��int�Ƃ�float�Ƃ��킩��Ȃ��Ȃ�l�̋~�ϑ[�u���E�ӂ̓��e����^���l���Ă����
        //var���g���Ƃ��͉E�ӂ��ȗ�����ƃo�O��
        var moveHorizontal = Input.GetAxis("Horizontal");//Horizontal�͐���
        var moveVertical = Input.GetAxis("Vertical");

        //�J�[�\���L�[�̓��͂ɍ��킹�Ĉړ�������ݒ�
        var movement=new Vector3(moveHorizontal,0,moveVertical);

        //Rigidbody�ɗ͂�^���ċ��𓮂���
        //movement�������A�x�N�g��
        rb.AddForce(movement*speed);

        if (transform.position.y < -10)
        {
            SceneManager.LoadScene("Roll a ball");
        }else if (transform.position.y > 150)
        {
            SceneManager.LoadScene("Roll a ball");
        }
        /*
        //�ȉ��S�s�ǉ�(2023/4/28)
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity=Vector3.up*jumpSpeed;
        }
        */
    }

    void OnTriggerEnter(Collider other)//�u���蔲���鎞�Ɏg���̂́H�v���u�I���g���K�[�G���^�[�v
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
