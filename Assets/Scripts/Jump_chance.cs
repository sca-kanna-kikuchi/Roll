using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump_chance : MonoBehaviour
{
    //�W�����v����́i������̗́j���`
    [SerializeField]private float jumpForce = 20.0f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //�������������Rigidbody�R���|�[�l���g���擾���āA������̗͂�������
            other.gameObject.GetComponent<Rigidbody>().AddForce(0,jumpForce,0,ForceMode.Impulse);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
