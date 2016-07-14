using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public Transform followTarget;

    private Vector3 offset;
    private Transform cachedTransform;

    // Use this for initialization
    void Start()
    {
        cachedTransform = this.transform;
        offset = cachedTransform.position - followTarget.position;
    }

    // Update is called once per frame
    void Update()
    {
        cachedTransform.position = followTarget.position + offset;
    }
}
