using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDiirection : MonoBehaviour
{

    [SerializeField] private float Turnspeed = 5f;

    void Update()
    {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Vector3 dir = hit.point - transform.position;
                Quaternion look = Quaternion.LookRotation(dir);
                transform.rotation = Quaternion.Slerp(transform.rotation, look, Turnspeed * Time.deltaTime);
            }
        }
 }

