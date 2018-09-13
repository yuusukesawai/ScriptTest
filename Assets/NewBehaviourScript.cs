using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityScript.Lang;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; //マジックポイント


    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }
    //魔法攻撃用の関数
    public void Magic(int minddamage)
    {   

        if (mp > minddamage)
        {
            //残りMPの表示
            this.mp -= minddamage;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else
        {
            //残りMPの表示
            Debug.Log("MPが足りない為、魔法が使えない。残りMP："+mp);

        }   
        

        
    }

}

public class NewBehaviourScript : MonoBehaviour
{
    void Hoge()
    {

        //要素数５の配列を初期化する。
        int[] array = { 1, 2, 3, 4, 5 };

        //配列の要素をすべて表示する。
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        //配列を逆表示する
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(i);
        }
    }

    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();


        for ( int i = 0; i < 15; i++)
        {
            lastboss.Magic(5);
        }

        Hoge();

    }
        
        

    
        // Update is called once per frame
        void Update()
        {

        }

    
}