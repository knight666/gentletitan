using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject m_titan;
    public Vector3 m_offset = new Vector3(0.0f, 0.0f, -10.0f);

    void Start()
    {
        m_offset = transform.position - m_titan.transform.position;
    }

    void LateUpdate()
    {
        transform.position = m_titan.transform.position + m_offset;
    }
}