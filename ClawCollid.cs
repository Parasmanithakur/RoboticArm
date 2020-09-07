using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawCollid : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool Iscollid = false;
    public GameObject Claw1, Claw2;
    public float speed = 50.0f;
    public float minDist = 0.5f;
    public Transform target;
    public GameObject ParticleSystem,AudioSystem;
    Vector3 pos;

    void Start()
    {
        target = GameObject.FindWithTag("Claw1").GetComponent<Transform>();
    }
    private void Update()
    {
        pos = (Claw1.transform.position + Claw2.transform.position);
        if(Iscollid)
        {
            transform.position = pos / 2;
        }
        if(Iscollid && Input.GetKey(KeyCode.M))
        {
            Iscollid = false;
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.useGravity = true;
            Rotate.Dorotae = false;
            rb.isKinematic = false;
        }
        /*if (Iscollid)
        {
            
            float distance = Vector3.Distance(transform.position, target.position);
            if (distance > minDist)
            {
                transform.LookAt(target);
                transform.position += transform.forward * speed * Time.deltaTime;
            }
        }*/

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Claw1" || other.gameObject.tag == "Claw1")
        {
            Iscollid = true;
            ParticleSystem.SetActive(false);

        }
        if (other.gameObject.tag== "Surface")
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.useGravity = false;

            rb.isKinematic = true;

        }
        if( other.gameObject.tag =="FinalPt")
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.useGravity = false;
            
            rb.isKinematic = true;
            AudioSystem.SetActive(true);
        }
    }
}
