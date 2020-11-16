using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{

    public int someNumber = 0;
    public int pointsGiven = 10;
    public int blockHits = 3;
    private int startingBlockHits;


    public Sprite[] crackedSprites;

    // Start is called before the first frame update
    void Start()
    {
        startingBlockHits = blockHits;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.totalPoints = GameManager.totalPoints + pointsGiven;
        //Debug.Log("Total Points Score " + GameManager.totalPoints);
        //gameObject.SetActive(false);
        blockHits = blockHits - 1;
        //GetComponent<SpriteRenderer>().sprite = crackSprite;
        if (blockHits < startingBlockHits) 
        {
            if (blockHits == 2)
            {
                GetComponent<SpriteRenderer>().sprite = crackedSprites[0];
            }
            else if(blockHits == 1) 
            {
                GetComponent<SpriteRenderer>().sprite = crackedSprites[1];
            }
        }

        if (blockHits <= 0) 
        {
            Destroy(gameObject);
        }

        
    }
}
