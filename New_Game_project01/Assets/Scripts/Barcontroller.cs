using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barcontroller : MonoBehaviour
{
    private void LOnClick()
    {
        GameObject obj = GameObject.Find("Bar");
        obj.transform.Translate(0.5f, 0.0f, 0.0f);
    }

    private void ROnClick()
    {
        GameObject obj = GameObject.Find("Bar");
        obj.transform.Translate(-0.5f, 0.0f, 0.0f);
    }
}
