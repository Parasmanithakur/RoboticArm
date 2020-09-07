using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IkManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Joint m_root;
    public float m_rate = 5f;
    public Joint m_end;
    public int m_steps = 20;
    public GameObject m_target;
    public float m_threshold = 0.01f;
    float GetDistance(Vector3 _point1,Vector3 _point2)
    {
        return Vector3.Distance(_point1, _point2);
    }
    float CalculateSlope(Joint _joint)
    {
        float DeltaTheta = 0.01f;
        float distance1 = GetDistance(m_end.transform.position, m_target.transform.position);
        _joint.Rotate(DeltaTheta);
        float distance2 = GetDistance(m_end.transform.position, m_target.transform.position);
        _joint.Rotate(-DeltaTheta);
        return (distance2 - distance1) / DeltaTheta;
    }
    void Update()
    { 
        for (int i=0;i <m_steps;i++)
        {
            if (GetDistance(m_end.transform.position, m_target.transform.position) > m_threshold)
            {
                Joint current = m_root;
                while (current != null)
                {
                    float slope = CalculateSlope(m_root);
                    current.Rotate(-slope * m_rate *Time.deltaTime);
                    current = current.GetChild();
                }
            }
        }
       
    }

    // Update is called once per frame
   
}
