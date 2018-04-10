using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;

    // 魔法用の関数
    public void Magic()
    {
        if (mp >= 5) {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        } else {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour {

    // Use this for initialization
    void Start () {
        // 要素数5の配列を作成し、初期値を設定する
        int[] array = { 10, 20, 30, 40, 50 };

        // 配列の中身を順に表示
		for (int i = 0; i < array.Length; i++) {
            Debug.Log(array[i]);
        }

        // Bossクラスを呼び出し、11回繰り返す
        Boss boss = new Boss();
        for (int j = 0; j < 11; j++) {
            boss.Magic();
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
