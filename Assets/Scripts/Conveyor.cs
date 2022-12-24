using UnityEngine;

public class Conveyor : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void OnCollisionStay(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Player")
        {
            collisionInfo.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * _speed);

        }
    }
}    
