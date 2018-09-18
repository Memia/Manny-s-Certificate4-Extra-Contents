using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbit : MonoBehaviour
{
    public Transform target;
    [Header("Settings")]
    public Vector3 offset;
    public Vector2 speed = new Vector2(120f, 120f);
    public float minY = -20f; //Limit in degrees of rotation of y
    public float maxY = 80f;
    public float minDistance = .5f;
    public float maxDistance = 15f;
    public bool hideCursor;
    [Header("Collision")]
    public bool collision = false;
    public float castRadius = .4f;
    public float rayDistance = 1000f;
    public LayerMask ignoreLayers;

    private Vector3 originalOffset;
    private float distance;
    private float x, y;

    // Use this for initialization
    void Start()
    {
        if (hideCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
