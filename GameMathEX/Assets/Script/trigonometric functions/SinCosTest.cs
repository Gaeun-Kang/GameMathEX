using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinCosTest : MonoBehaviour
{
    public float angle = 0;
    void Start()
    {
        Debug.Log(angle + "�� Sin ����" + Mathf.Sin(angle * Mathf.Deg2Rad));
        Debug.Log(angle + "�� Cos ����" + Mathf.Cos(angle * Mathf.Deg2Rad));
    }

  
}
