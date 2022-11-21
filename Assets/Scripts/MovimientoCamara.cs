using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{
    public Vector3 offset;
    private Transform target;
    public float sensibilidad; 
    [Range(0,1)]public float lerpValue;

    void Start()
    {
        target = GameObject.Find("PersonajePrincipal").transform;
    }
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position,target.position + offset,lerpValue);
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * sensibilidad, Vector3.up) * offset;
        transform.LookAt(target);
    }
}
