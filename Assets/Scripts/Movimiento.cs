using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    private Vector3 initialPos = new Vector3(0, 0, 0);
    public float speed = 4f;
    public float runSpeed = 7f;
    public float rotSpeed = 40f;
    public float rot = 0f;
    public Vector3 moveDir = Vector3.zero;
    private CharacterController controller;

    private float horizontalInput;
    private float verticalInput;
    private float xRange = 15f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = initialPos;
    }

    // Update is called once per frame
    void Update()
    {
        // Movimiento horizontal del player
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        // Movimiento vertical del player
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * Time.deltaTime * speed * verticalInput);
    }
}