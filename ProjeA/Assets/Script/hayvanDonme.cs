using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class hayvanDonme : MonoBehaviour
{
    Vector3 firstpos, lastpos;
    public GameObject animal;
    float anglex,speed=25;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Input.mousePosition;
            pos.z = 10;
            firstpos = Camera.main.ScreenToWorldPoint(pos);

        }
        if (Input.GetMouseButton(0))
        {
            Vector3 pos = Input.mousePosition;
            pos.z = 10;
            lastpos = Camera.main.ScreenToWorldPoint(pos);
            anglex += firstpos.x - lastpos.x;
            transform.rotation = Quaternion.Euler(0, anglex*speed, 0);
            firstpos = lastpos;

        }
    }

}
