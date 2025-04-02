using UnityEngine;

public class PendulumStarter : MonoBehaviour
{
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.right * 5f, ForceMode.Impulse);
    }
}