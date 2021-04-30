using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMove : MonoBehaviour
{
    public float speed = 5;

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.z = position.z + speed * Time.deltaTime;
        //다시 할당 잊지말자.
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
