using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodTrigger : MonoBehaviour {

    public GameObject m_prefabMiniGame;
    private GameObject m_miniGame;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "player")
        {
            m_miniGame = GameObject.Instantiate(m_prefabMiniGame);
            m_miniGame.GetComponent<MiniWood>().Titan = coll.gameObject;
        }
    }
}
