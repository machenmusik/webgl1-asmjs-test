using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateY : MonoBehaviour
{
    Quaternion q;
    Vector3 eulerAngles;

    public float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        q = new Quaternion();
        eulerAngles = new Vector3();
    }

    // Update is called once per frame
    void Update()
    {
        eulerAngles.Set(
            this.transform.rotation.eulerAngles.x, 
            speed * Time.time, 
            this.transform.rotation.eulerAngles.z);

        q.eulerAngles = eulerAngles;

        this.transform.rotation = q;
    }
}
