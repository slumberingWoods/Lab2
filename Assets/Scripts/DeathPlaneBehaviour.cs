using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlaneBehaviour : MonoBehaviour
{
    Vector3 originalPlayerPosition;
    public GameObject Player;
    void Start()
    {
        originalPlayerPosition = Player.transform.position;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            Reset();
        }
    }
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Player.transform.position = originalPlayerPosition;
        }

    }
    public void Reset()
    {
        Player.transform.position = originalPlayerPosition;
    }
}
