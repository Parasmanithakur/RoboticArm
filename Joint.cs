using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joint : MonoBehaviour
{
    public Joint m_child;
    public Joint GetChild()
    {
        return m_child;
    }
    // Start is called before the first frame update
    public void Rotate(float _angle)
    {
        transform.Rotate(Vector3.up * _angle);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
