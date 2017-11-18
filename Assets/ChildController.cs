using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChildController : MonoBehaviour
{
    public GameObject m_titan;
    public GameObject m_textHunger;
    public GameObject m_textCold;
    public GameObject m_textDanger;

    public float m_hunger = 0.0f;
    public float m_hungerSpeed = 1.0f;
    public float m_cold = 0.0f;
    public float m_coldSpeed = 0.5f;
    public float m_danger = 0.0f;
    public float m_dangerSpeed = 1.0f;

    public Text endGame;

    void Start()
    {
        endGame.enabled = false;
    }

    void LateUpdate()
    {
        m_hunger += m_hungerSpeed * Time.deltaTime;

        m_cold += m_coldSpeed * Time.deltaTime;

        if (Vector3.Distance(m_titan.GetComponent<Transform>().position, transform.position) > 5.0f)
        {
            m_danger += m_dangerSpeed * Time.deltaTime;
        }
        else
        {
            m_danger -= m_dangerSpeed * 5.0f * Time.deltaTime;
        }

        m_hunger = Mathf.Clamp(m_hunger, 0.0f, 100.0f);
        m_textHunger.GetComponent<Text>().text = "Hunger: " + m_hunger.ToString("f0");

        m_cold = Mathf.Clamp(m_cold, 0.0f, 100.0f);
        m_textCold.GetComponent<Text>().text = "Cold: " + m_cold.ToString("f0");

        m_danger = Mathf.Clamp(m_danger, 0.0f, 100.0f);
        m_textDanger.GetComponent<Text>().text = "Danger: " + m_danger.ToString("f0");
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            var titan = coll.gameObject.GetComponent<TitanController>();
            if (titan.m_wood > 0.0f)
            {
                StartCoroutine(AddWood(titan));
            }
        }
    }

    void EndGame()
    {
        if (m_hunger >= 100.0f || m_cold >= 100.0f || m_danger >= 100.0f)
        {
            endGame.enabled = true;
        }
    }

    IEnumerator AddWood(TitanController titan)
    {
        while (titan.m_wood > 0.1f)
        {
            yield return new WaitForSeconds(0.2f);

            m_cold -= m_coldSpeed * 3.0f;
            m_textCold.GetComponent<Text>().text = "Cold: " + m_cold.ToString("f0");

            titan.m_wood -= 1.0f;
        }

        titan.m_wood = 0.0f;
    }
}
