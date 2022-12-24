using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] private Text _countCoinsText;
    private int _countCoins = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            _countCoins += 1;
            _countCoinsText.text = _countCoins.ToString();
        }
    }
}
