using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float countTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //countTime�ɁA�Q�[�����J�n���Ă���̕b�����i�[
        countTime += Time.deltaTime;

        //����2���ɂ��ĕ\��
        GetComponent<Text>().text = countTime.ToString("F2");

    }
}
