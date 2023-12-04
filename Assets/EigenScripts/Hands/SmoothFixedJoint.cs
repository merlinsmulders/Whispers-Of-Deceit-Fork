using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFixedJoint : MonoBehaviour
{
    public GameObject target;
    public float speed;
    void Update()
    {
        if(Vector3.Distance(target.transform.position, transform.position) < 0.05f)
        {
            this.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
        else
        {
            this.GetComponent<Rigidbody>().velocity = Vector3.zero;
            this.GetComponent<Rigidbody>().AddForce(speed *(target.transform.position - transform.position));
        }
        transform.localRotation = Quaternion.Lerp(transform.localRotation, target.transform.localRotation,speed * Time.deltaTime);
    }
}
