    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitanController : MonoBehaviour {

    public GameObject m_prefabWood;
    public GameObject m_prefabFood;
    public GameObject m_textEnergy;
    public GameObject m_textHealth;
    public GameObject m_textFood;
    public GameObject m_textWood;
    public float m_movementSpeed = 3.0f;
    public float m_energy = 100.0f;
    public float m_health = 100.0f;
    public float m_wood = 0.0f;
    public float m_food = 0.0f;

    private GameObject m_miniGame;

    void Update ()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * m_movementSpeed * Time.deltaTime;
            m_energy -= 0.1f;
            if (m_energy <= 0.0f)
            {
                m_health -= 0.1f;
            }
        }
        else if (
            Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * m_movementSpeed * Time.deltaTime;
            m_energy -= 0.1f;
            if (m_energy <= 0.0f)
            {
                m_health -= 0.1f;
            }
        }
        else
        {
            m_energy += 0.1f;
        }
    }

    void LateUpdate()
    {
        m_energy = Mathf.Clamp(m_energy, 0.0f, 100.0f);
        m_textEnergy.GetComponent<Text>().text = "Energy: " + m_energy.ToString("f0");

        m_health = Mathf.Clamp(m_health, 0.0f, 100.0f);
        m_textHealth.GetComponent<Text>().text = "Health: " + m_health.ToString("f0");

        m_wood = Mathf.Clamp(m_wood, 0.0f, 100.0f);
        m_textFood.GetComponent<Text>().text = "Wood: " + m_wood.ToString("f0");

        m_food = Mathf.Clamp(m_food, 0.0f, 100.0f);
        m_textWood.GetComponent<Text>().text = "Food: " + m_food.ToString("f0");
    }

    void OnCollisionEnter(Collision coll)
    {
        Debug.Log(coll);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        //Debug.Log(coll);
        if (coll.gameObject.tag == "wood" &&
            m_miniGame == null)
        {
            m_miniGame = GameObject.Instantiate(m_prefabWood);
            m_miniGame.GetComponent<MiniWood>().Titan = gameObject;
        }

        if (coll.gameObject.tag == "food" &&
            m_miniGame == null)
        {
            m_miniGame = GameObject.Instantiate(m_prefabFood);
            m_miniGame.GetComponent<MiniFood>().Titan = gameObject;
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

        if (coll.gameObject.tag == "food" &&
            m_miniGame != null)
        {
            GameObject.Destroy(m_miniGame);
            m_miniGame = null;
        }
    }
}
