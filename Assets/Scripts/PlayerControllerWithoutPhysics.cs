using UnityEngine;

public class PlayerControllerWithoutPhysics : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody _rigidbody;
    private bool _cubeIsOnTheGround = true;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * _speed * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * _speed * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * _speed * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * _speed * Time.fixedDeltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space) && _cubeIsOnTheGround == true)
        {
            _rigidbody.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            _cubeIsOnTheGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            _cubeIsOnTheGround = true;
        }
    }
}
