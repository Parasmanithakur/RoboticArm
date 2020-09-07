using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTarget : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementspeed = 50.5F;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            transform.Translate(Vector2.left * movementspeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.D))
            transform.Translate(Vector2.right * movementspeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.W))
            transform.Translate(Vector2.up * movementspeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.S))
            transform.Translate(Vector2.down * movementspeed * Time.deltaTime);


    }
}
