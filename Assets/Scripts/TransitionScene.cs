using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionScene : MonoBehaviour
{  
    public void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("SecondLevel");
    }
}
