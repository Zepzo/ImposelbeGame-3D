using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerusObjects : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerMovment player = collision.gameObject.GetComponent<PlayerMovment>();
            player.death();
        }
    }
}
