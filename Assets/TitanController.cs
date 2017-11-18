    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitanController : MonoBehaviour {

    public GameObject m_prefabMiniGame;
    public float m_movementSpeed = 3.0f;
    public float m_wood = 0.0f;
    public float m_food = 0.0f;

    private GameObject m_miniGame;

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

    void OnCollisionEnter(Collision coll)
    {
        Debug.Log(coll);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        //Debug.Log(coll);
        if (coll.gameObject.tag == "wood")
        {
            m_miniGame = GameObject.Instantiate(m_prefabMiniGame);
            m_miniGame.GetComponent<MiniWood>().Titan = gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "wood" &&
            m_miniGame != null)
        {
            GameObject.Destroy(m_miniGame);
            m_miniGame = null;
        }
    }
}
