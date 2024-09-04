using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WoodCollection2 : MonoBehaviour
{
    public int Wood2 = 0;
    public TextMeshProUGUI woodtext;

   
    private CoinCollection coinCollection;

    private void Start()
    {
        
        coinCollection = FindObjectOfType<CoinCollection>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Wood")
        {
            Wood2++;
            woodtext.text = Wood2.ToString() + " /15";

            Destroy(other.gameObject);
        }
    }

    private void Update()
    {

        if (coinCollection.Coin == 20 && Wood2 == 15)
        {
            SceneManager.LoadSceneAsync(6);
        }
    }
}