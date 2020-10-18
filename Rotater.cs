using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + 0.001f;
        Vector3 pos = this.transform.position;
        pos.y = this.transform.position.y + Mathf.Round(((Mathf.Cos(timer * 700)) * 6) + 10);
        this.transform.position = pos;
        Quaternion rot = this.transform.rotation;
        rot.z = this.transform.rotation.z + Mathf.Round(((Mathf.Cos(timer * 200)) * 50) + 20);
        this.transform.rotation = rot;

    }
}
