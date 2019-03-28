using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // 体力
    private int mp = 53;    //MP
    private int power = 25; // 攻撃力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    //魔法攻撃
    public void Magic(int MagicUse)
    {
        int AfterMp;

        if (this.mp >= MagicUse)
        {
            AfterMp = this.mp -= MagicUse;
            Debug.Log("魔法攻撃をした。残りMPは" + AfterMp + "。");
        }
        else
        {
            AfterMp = this.mp;
            Debug.Log("MPが足りないため魔法が使えない。残りMPは" + AfterMp + "。");
        }
        
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

}

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();

        //魔法用
        for (int i =0; i<15;i++)
        {
            lastboss.Magic(5);
        }

        // 防御用の関数を呼び出す
        lastboss.Defence(3);


        
        int[] array = {100,200,300,400,500};

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int f = 4; f>=0; f--)
        {
            Debug.Log(array[f]);
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
