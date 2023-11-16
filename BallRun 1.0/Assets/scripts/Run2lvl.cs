using UnityEngine;

public class Run2lvl : MonoBehaviour
{
    private float _speed = 45f;

    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        _rb.AddForce(new Vector3(-h, 0, -v) * _speed * Time.fixedDeltaTime);

    }
}
