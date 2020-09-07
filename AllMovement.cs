using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10.0f;
    public GameObject Base, A1, A2, A3, A4;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (IkManager1.IsIkON == false)
        {
            if (Input.GetKey(KeyCode.E))
                A3.transform.Rotate(Vector3.back * Time.deltaTime * speed);
            if (Input.GetKey(KeyCode.R))
                A3.transform.Rotate(Vector3.forward * Time.deltaTime * speed);
            if (Input.GetKey(KeyCode.Z))
                A2.transform.Rotate(Vector3.left * Time.deltaTime * speed);
            if (Input.GetKey(KeyCode.X))
                A2.transform.Rotate(Vector3.right * Time.deltaTime * speed);
            if (Input.GetKey(KeyCode.Q))
                Base.transform.Rotate(Vector3.back * Time.deltaTime * speed);
            if (Input.GetKey(KeyCode.W))
                Base.transform.Rotate(Vector3.forward * Time.deltaTime * speed);

            if (Input.GetKey(KeyCode.A))
                A1.transform.Rotate(Vector3.up * Time.deltaTime * speed);
            if (Input.GetKey(KeyCode.S))
                A1.transform.Rotate(Vector3.down * Time.deltaTime * speed);
            if (Input.GetKey(KeyCode.B))
                A4.transform.Rotate(Vector3.left * Time.deltaTime * speed);
            if (Input.GetKey(KeyCode.N))
                A4.transform.Rotate(Vector3.right * Time.deltaTime * speed);

            if (Input.GetKey(KeyCode.T))
                A4.transform.Rotate(Vector3.back * Time.deltaTime * speed);
            if (Input.GetKey(KeyCode.Y))
                A4.transform.Rotate(Vector3.forward * Time.deltaTime * speed);

            if (Input.GetKey(KeyCode.G))
                A4.transform.Rotate(Vector3.up * Time.deltaTime * speed);
            if (Input.GetKey(KeyCode.H))
                A4.transform.Rotate(Vector3.down * Time.deltaTime * speed);
        }
    }
}