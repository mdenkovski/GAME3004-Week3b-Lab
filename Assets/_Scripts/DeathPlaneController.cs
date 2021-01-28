using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlaneController : MonoBehaviour
{
    public Transform spawnPoint;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            var player = other.GetComponent<PlayerBehaviour>();
            player.controller.enabled = false;
            player.transform.position = spawnPoint.position;
            player.controller.enabled = true;
        }
    }
}
