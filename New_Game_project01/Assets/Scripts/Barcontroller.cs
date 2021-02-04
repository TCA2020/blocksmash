using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barcontroller : MonoBehaviour
{
    private void Start(){

    }

    public void LOnClick()
    {
        GameObject obj = GameObject.Find("Bar");
        obj.transform.Translate(0.5f, 0.0f, 0.0f);
    }

    public void ROnClick()
    {
        GameObject obj = GameObject.Find("Bar");
        obj.transform.Translate(-0.5f, 0.0f, 0.0f);
    }
}
