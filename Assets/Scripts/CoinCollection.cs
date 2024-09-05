using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CoinCollection : MonoBehaviour
{

    public int Coin = 0;

    public TextMeshProUGUI coinText;


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Coins")
        {
            Coin++;
            coinText.text = Coin.ToString() + " /15";

            Destroy(other.gameObject);
        }

    }
    public void Update()
    {
        if (Coin == 15)
        {
            SceneManager.LoadSceneAsync(3);
        }

    }
}
