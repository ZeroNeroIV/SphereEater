using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 5f; 
    private Rigidbody m_rb;

    // Start is called before the first frame update
    private void Start()
    {
        m_rb = GetComponent<Rigidbody>();

        m_rb.freezeRotation = true;
    }

    // Update is called once per FIXED frame
    private void FixedUpdate()
    {
        Move();
    }

    private void Move() {
        var left = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
        var right = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);
        
        if (left && !right) {
            // transform.Translate(Vector3.forward * (speed * Time.fixedDeltaTime));
            m_rb.AddForce(Vector3.forward * (speed * Time.fixedDeltaTime), ForceMode.Impulse);
        }
        if (!left && right) {
            // transform.Translate(Vector3.back * (speed * Time.fixedDeltaTime));
            m_rb.AddForce(new Vector3(0, 0, -(speed * Time.fixedDeltaTime)), ForceMode.Impulse);
        }
    }

}
