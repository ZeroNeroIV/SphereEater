using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automation : MonoBehaviour
{
    [SerializeField] private float speed = 15f;
    private Rigidbody m_rb;

    // Start is called before the first frame update
    void Start()
    {
        m_rb = GetComponent<Rigidbody>();
        Destroy(gameObject, 15f);
    }

    // Update is called once per frame
    void Update()
    {
        m_rb.AddForce(Vector3.left * (speed * Time.deltaTime), ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            GameM.instance.AddScore(1);
            Destroy(gameObject);
        }
    }
}
