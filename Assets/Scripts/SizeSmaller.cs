using UnityEngine;

public class SizeSmaller : MonoBehaviour
{
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            collisionInfo.gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
    }
}