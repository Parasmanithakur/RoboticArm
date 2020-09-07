using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joint1 : MonoBehaviour
{
    public Joint1 m_child;
    public char m_AxisAngle;
    public char GetChildAngle()
    {
        return m_AxisAngle;
    }
    public Joint1 GetChild()
    {
        return m_child;
    }
    // Start is called before the first frame update
    public void Rotate(float _angle)
    {
        if(m_AxisAngle == 'z' || m_AxisAngle == 'Z')
        transform.Rotate(Vector3.forward * _angle);
        if (m_AxisAngle == 'x'|| m_AxisAngle == 'X')
            transform.Rotate(Vector3.right * _angle);
        if (m_AxisAngle == 'y' || m_AxisAngle == 'Y')
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
