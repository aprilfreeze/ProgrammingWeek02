using UnityEngine;
using System.Collections;

public class PlayerRespawn : MonoBehaviour
{
    //respawning
    public Transform SpawnPoint;
    public bool isDead;

    public void Start()
    {
        this.transform.position = SpawnPoint.position;
    }

    public void OnTriggerEnter( Collider other )
    {
        //Respawn on death 
        if( other.CompareTag( "DeathCube" ) )
        {
            isDead = true;
            this.transform.position = SpawnPoint.position;
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}