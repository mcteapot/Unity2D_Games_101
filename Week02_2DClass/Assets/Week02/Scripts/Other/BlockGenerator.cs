using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{

    public int totalBlocks = 5;
    public GameObject blockPrefab;
    public float blockDistance = 0.5f;
    public Color blockColors;
    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < totalBlocks; i++) 
        {
            float blockDistanceSpace = blockDistance * i;
            Debug.Log("Total Blocks: " + i);
            Vector3 blockPosition = new Vector3(transform.position.x + blockDistanceSpace, transform.position.y, transform.position.z);
            GameObject createdBlock = Instantiate(blockPrefab, blockPosition, Quaternion.identity);
            createdBlock.GetComponent<SpriteRenderer>().color = blockColors;

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
