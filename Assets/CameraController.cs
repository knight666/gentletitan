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
        Vector3 target = m_titan.transform.position + m_offset;
        transform.position += (target - transform.position) * 0.97f * Time.deltaTime;
    }
}