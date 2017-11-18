    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitanController : MonoBehaviour {

    public float m_movementSpeed = 3.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * m_movementSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * m_movementSpeed * Time.deltaTime;
        }
    }
}
