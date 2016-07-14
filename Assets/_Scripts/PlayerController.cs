using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    //public float playerSpeed = 1.5f;

    //respawning
    public Vector3 SpawnPoint;
    public bool isDead;

    private Rigidbody cachedRigidbody;
	// Use this for initialization
	void Start ()
    {
        //cachedRigidbody = GetComponent<Rigidbody>();
        //SpawnPoint = cachedRigidbody.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

       // cachedRigidbody.AddForce(h * playerSpeed, 0f, v * playerSpeed);
	}

    public void OnTriggerEnter( Collider other )
    {
        if( other.CompareTag( "Cube" ) )
        {
            other.gameObject.SetActive( false );
        }
        //Respawn on death 
        if( other.CompareTag( "DeathCube" ) )
        {
            isDead = true;
            this.transform.position = SpawnPoint;
        }
    }
}