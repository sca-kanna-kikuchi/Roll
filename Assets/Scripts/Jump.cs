using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    //�W�����v����́i������̗́j���`
    [SerializeField]private float jumpForce = 20.0f;
    private void OnTriggerEnter(Collider other)
    {
        //������������̃^�O��Player�������ꍇ
        if (other.gameObject.CompareTag("Player"))
        {
            //�������������Rigidbody�R���|�[�l���g���擾���āA������̗͂�������
            other.gameObject.GetComponent<Rigidbody>().AddForce(0,jumpForce,0,ForceMode.Impulse);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
