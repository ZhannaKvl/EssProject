using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTransform : MonoBehaviour
{
    public Vector3 scaleChange;
    public float speed;
    void Start()
    {
        speed = Random.value;
    }

    void Update()
    {
        transform.localScale += scaleChange;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
