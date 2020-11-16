using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictinaryLearning : MonoBehaviour
{
    public Dictionary<string, float> itemPrices = new Dictionary<string, float>();
    public string storeItem = "Veggie";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("DictinaryLearning Script Workign");

        itemPrices.Add("Veggie", 14.99f);
        itemPrices.Add("Meat", 12.99f);
        itemPrices.Add("Cheese", 18.99f);
        itemPrices.Add("Soda", 16.99f);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("The price of " + storeItem + " is " + itemPrices[storeItem]);
            ///Debug.Log("Player " + playerNumber + " name is " + playerNames[playerNumber]);
        }
    }
}
