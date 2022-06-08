using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 0から順に数を代入する、宣言もする
        int[] array = { 1, 2, 3, 4, 5 };
        // 配列の各要素を順に表示
       // for (int i = 0; i < array.Length; i++)
        {
          //  Debug.Log(array[i]);
        }
        // 配列の要素を逆順に表示
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
