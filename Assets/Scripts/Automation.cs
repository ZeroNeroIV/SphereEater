using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automation : MonoBehaviour
{
    [SerializeField] private float speed = 15f;
    private Rigidbody m_rb;

    private void Start()
    {
        m_rb = GetComponent<Rigidbody>();
        Destroy(gameObject, 15f);
    }

    private void FixedUpdate() => m_rb.AddForce(Vector3.left * (speed * Time.fixedDeltaTime), ForceMode.Impulse);

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            GameM.instance.AddScore(1);
            Destroy(gameObject);
        }
    }
}
