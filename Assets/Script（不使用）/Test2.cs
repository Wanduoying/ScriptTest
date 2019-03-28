using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //numを1にて初期化
        //int num = 1;
        //三項演算子を以てvalに代入する價を條件によりて變ふ
        //int val = (num == 1) ? -100 : 100;
        //valの價を表示す
        //Debug.Log(val);

        int val;
        int num = 1;

        if(num == 1)
        {
            val = -100;
        }
        else
        {
            val = 100;
        }
        Debug.Log(val);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
