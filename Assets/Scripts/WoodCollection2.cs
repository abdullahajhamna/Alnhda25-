using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WoodCollection2 : MonoBehaviour
{
    public int Wood = 0;
    public TextMeshProUGUI woodtext;

    // المرجع لسكربت CoinCollection
    private CoinCollection coinCollection;

    private void Start()
    {
        // العثور على سكربت CoinCollection الموجود على نفس GameObject أو أي كائن آخر
        coinCollection = FindObjectOfType<CoinCollection>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Wood")
        {
            Wood++;
            woodtext.text = Wood.ToString() + " /15";

            Destroy(other.gameObject);
        }
    }

    private void Update()
    {
        
        if ( coinCollection.Coin == 20 && Wood == 15)
        {
            SceneManager.LoadSceneAsync(6);
        }
    }
}