using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pendulum : MonoBehaviour
{
    public float angle = 0;
    public float speed = 2f;
    private float lerpTime = 0;
    

    private void Update()
    {
        lerpTime += Time.deltaTime * speed;
        transform.rotation = CalculateMovementOfPendulum();
    }

    Quaternion CalculateMovementOfPendulum()
    {
        return Quaternion.Lerp(Quaternion.Euler(Vector3.forward * angle),
            Quaternion.Euler(Vector3.back * angle), GetLerpTParam());
    }

    float GetLerpTParam()
    {
        return (Mathf.Sin(lerpTime) + 1) * 0.5f;
    }
}
