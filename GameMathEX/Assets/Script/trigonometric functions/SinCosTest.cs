using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinCosTest : MonoBehaviour
{
    public float angle = 0;
    void Start()
    {
        Debug.Log(angle + "의 Sin 값은" + Mathf.Sin(angle * Mathf.Deg2Rad));
        Debug.Log(angle + "의 Cos 값은" + Mathf.Cos(angle * Mathf.Deg2Rad));
    }

  
}
