using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test04 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //要素數5の配列を初期化す
        //int[] points = new int[5];

        //配列の各要素に價を代入す
        //points[0] = 30;
        //points[1] = 20;
        //points[2] = 50;
        //points[3] = 10;
        //points[4] = 80;

        //配列の要素を全て表示す
        //for(int i = 0; i<5; i++)
        //{
        //    Debug.Log(points[i]);
        //}


        //配列初期化
        int[] points = { 30, 20, 50, 10, 80, 15, 60, 100 };

        //配列の要素數の分だけ處理を繰り返す
        for (int i = 0; i < points.Length; i++){
            //配列の要素が50以上の場合
            if (points[i] >= 50)
            {
                //配列の要素を表示す
                Debug.Log(points[i]);
            }
         }


    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
