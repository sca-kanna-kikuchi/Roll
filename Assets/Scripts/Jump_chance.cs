using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump_chance : MonoBehaviour
{
    //ジャンプする力（上向きの力）を定義
    [SerializeField]private float jumpForce = 20.0f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //当たった相手のRigidbodyコンポーネントを取得して、上向きの力を加える
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
