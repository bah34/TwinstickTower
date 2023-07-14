using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerT;

    [SerializeField]
    [Range(-40f, 40f)]
    private float yOffset;

    [SerializeField]
    [Range(-40f, 40f)]
    private float zOffset;

    [SerializeField]
    [Range(-40f, 40f)]
    private float xOffset;

    [SerializeField]
    [Range(-9f, 9f)]
    private float zRot;

    void Start()
    {
        yOffset = 2f;
        zOffset = 2f;
        zRot = 35f;
    }

    void LateUpdate()
    {
        transform.position = new Vector3(playerT.position.x + xOffset, playerT.position.y + yOffset, playerT.position.z - zOffset);
        transform.rotation = Quaternion.Euler(new Vector3(zRot, 0, 0));
    }
}
