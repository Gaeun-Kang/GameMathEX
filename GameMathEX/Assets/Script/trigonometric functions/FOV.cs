using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class FOV : MonoBehaviour
{

    public float FovDistance, FovAngle;

    void Update()
    {
     
    }
   

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
    //  Gizmos.DrawWireSphere(transform.position, FovDistance);
        //원하는 FOV 각도 지정 
        Vector3[] FosPos = CaculateFOV(FovDistance, FovAngle);

        for(int i = 0; i < FosPos.Length; i++)
        {
            Gizmos.DrawLine(transform.position, transform.position + FosPos[i]);
        }
    }

    //FOV 범위 : 길이와 각도가 필요함 
    private Vector3[] CaculateFOV(float radius, float angle)
    {
        //FOV 구현을 위해 두 개의 선을 그린다. 즉 Vector3이 두 개 필요함
        Vector3[] results = new Vector3[2];

        float theta = 90 - angle - transform.eulerAngles.y;

        //x의 길이. 즉, 밑변의 길이이므로 cos 사용 
        float rightX = Mathf.Cos(theta * Mathf.Deg2Rad) * radius;
        float rightY = transform.position.y;
        //y의 길이. 즉, 높이의 길이이므로 sin 사용 
        float rightz = Mathf.Sin(theta * Mathf.Deg2Rad) * radius;

        results[0] = new Vector3(rightX, rightY, rightz);

        //90도를 넘을 것이기 때문에 + 처리 
        theta = 90 + angle - transform.eulerAngles.y; 
        //x의 길이. 즉, 밑변의 길이이므로 cos 사용 
        float leftX = Mathf.Cos(theta * Mathf.Deg2Rad) * radius;
        float leftY = transform.position.y;
        //y의 길이. 즉, 높이의 길이이므로 sin 사용 
        float leftz = Mathf.Sin(theta * Mathf.Deg2Rad) * radius;

        results[1] = new Vector3(leftX, leftY, leftz);
        return results;
    }
}
