using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test07 : MonoBehaviour
{
    //第一引數と第二引數の價を足した價を返す函數
    int Add(int a,int b,int c)
    {
        //第一引數と第二引數の價を足して變數dに代入す
        int d = a + b+c;
        //變數cを呼び出し元の函數に返す
        return d;
    }


    void Start()
    {
        //Add函數に3と6と5の引數を渡し、戻り値をnum變數に代入す
        int num = Add(3, 6,5);
        //numを表示す
        Debug.Log(num);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
