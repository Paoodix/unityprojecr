using UnityEngine;

public class SizeLarger : MonoBehaviour 
{
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            collisionInfo.gameObject.transform.localScale = new Vector3(4, 4, 4);
        }
    }
}
