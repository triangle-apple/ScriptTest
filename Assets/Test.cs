using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 0���珇�ɐ���������A�錾������
        int[] array = { 1, 2, 3, 4, 5 };
        // �z��̊e�v�f�����ɕ\��
       // for (int i = 0; i < array.Length; i++)
        {
          //  Debug.Log(array[i]);
        }
        // �z��̗v�f���t���ɕ\��
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
