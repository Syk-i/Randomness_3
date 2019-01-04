using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanceDrop : MonoBehaviour {
    public GameObject Coin;
    public int predict;
    public int roll;

    // Use this for initialization
    void Start () {
        roll = Random.Range(0, 3);
        predict = Random.Range(0, 3);
	}
	// Update is called once per frame
    public void ChanceSpawn()
    {
        if (predict == roll)
        {
            Debug.Log("CoinCOIN");
            gameObject.GetComponent<ChanceDrop>().ChanceSpawn();
        }

    }
}
