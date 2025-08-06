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
        //���ϴ� FOV ���� ���� 
        Vector3[] FosPos = CaculateFOV(FovDistance, FovAngle);

        for(int i = 0; i < FosPos.Length; i++)
        {
            Gizmos.DrawLine(transform.position, transform.position + FosPos[i]);
        }
    }

    //FOV ���� : ���̿� ������ �ʿ��� 
    private Vector3[] CaculateFOV(float radius, float angle)
    {
        //FOV ������ ���� �� ���� ���� �׸���. �� Vector3�� �� �� �ʿ���
        Vector3[] results = new Vector3[2];

        float theta = 90 - angle - transform.eulerAngles.y;

        //x�� ����. ��, �غ��� �����̹Ƿ� cos ��� 
        float rightX = Mathf.Cos(theta * Mathf.Deg2Rad) * radius;
        float rightY = transform.position.y;
        //y�� ����. ��, ������ �����̹Ƿ� sin ��� 
        float rightz = Mathf.Sin(theta * Mathf.Deg2Rad) * radius;

        results[0] = new Vector3(rightX, rightY, rightz);

        //90���� ���� ���̱� ������ + ó�� 
        theta = 90 + angle - transform.eulerAngles.y; 
        //x�� ����. ��, �غ��� �����̹Ƿ� cos ��� 
        float leftX = Mathf.Cos(theta * Mathf.Deg2Rad) * radius;
        float leftY = transform.position.y;
        //y�� ����. ��, ������ �����̹Ƿ� sin ��� 
        float leftz = Mathf.Sin(theta * Mathf.Deg2Rad) * radius;

        results[1] = new Vector3(leftX, leftY, leftz);
        return results;
    }
}
