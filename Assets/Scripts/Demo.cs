using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }

    void Rotate()
    {
        var angle = transform.localEulerAngles;
        angle.x += 1f;
        angle.z += 1f;
        transform.localEulerAngles = angle;
        Debug.Log(transform.localEulerAngles);
    }
}
