using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int money = 10000;

        if(money <= 50)
        {
            //moneyが50以下の場合
            Debug.Log("武器を賣る");
        }
        else if (money >= 1000)
        {
            //moneyが1000以上の場合
            Debug.Log("寶石を買ふ");
        }
        else if(money >= 200)
        {
            //moneyが200以上の場合
            Debug.Log("武器を買ふ");
        }
        else
        {
            //それ以外の場合
            Debug.Log("ポーションを買ふ");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
