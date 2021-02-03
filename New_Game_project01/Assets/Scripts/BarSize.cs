using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarSize: MonoBehaviour
{
    // 大きさをInspector上で自由に設定できるようにする
    [SerializeField]
    private int x;

    int r1;

    private void OnCollisionEnter(Collision other)
    {
        r1 = Random.Range(1, 4);
        transform.localScale = new Vector3(r1, 1, 0.5f);
        Debug.Log("当たったよ");

        Quaternion rotation = Quaternion.AngleAxis(25f, Vector3.right);
        other.transform.localPosition += rotation * new Vector3(0,0,-15);
    }
}
