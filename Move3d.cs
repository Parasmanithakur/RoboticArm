using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move3d : MonoBehaviour
{
    public float movementspeed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(IkManager1.IsIkON==true)
        {
            if (Input.GetKeyDown(KeyCode.A))
                transform.Translate(Vector3.left * movementspeed * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.D))
                transform.Translate(Vector3.right * movementspeed * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.W))
                transform.Translate(Vector3.up * movementspeed * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.S))
                transform.Translate(Vector3.down * movementspeed * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.X))
                transform.Translate(Vector3.forward * movementspeed * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.Z))
                transform.Translate(Vector3.back * movementspeed * Time.deltaTime);

        }
    }
}
