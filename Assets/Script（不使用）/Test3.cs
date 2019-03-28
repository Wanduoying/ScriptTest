using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //處理を五囘繰り返す
        //for (int i = 1; i<=5; i++)
        //{
        //    Debug.Log(i);
        //}




        //sumを0にて初期化
        int sum = 0;
        //處理を十囘行ふ
        for(int i=1; i<=10; i++)
        {
            //iの價をsumに足す
            sum += i;
            //sum += i; は sum = sum +i; に等し
        }
        //sumの價を表示す
        Debug.Log(sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
