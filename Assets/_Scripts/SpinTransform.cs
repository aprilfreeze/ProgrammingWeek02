using UnityEngine;
using System.Collections;

public class SpinTransform : MonoBehaviour
{
    public Vector3 spin;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(spin * Time.deltaTime);
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("yoo" + other.name);
    }
}
