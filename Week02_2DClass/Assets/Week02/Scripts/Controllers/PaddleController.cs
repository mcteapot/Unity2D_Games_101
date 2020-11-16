using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    //public GameObject paddleObject;

    // Start is called before the first frame update
    public float screenWidthInUnits = 16f;
    public float xMin = 0f;
    public float xMax = 16f;

    public float unusedValue = 0;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //UnityEngine.Debug.Log("Mouse Position: " + Input.mousePosition);

        MousePositionTracking();

    }

    private void MousePositionTracking()
    {
        float mousePositionUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        mousePositionUnits = Mathf.Clamp(mousePositionUnits, xMin, xMax);
        Vector3 positionOfPaddle = new Vector3(mousePositionUnits, transform.position.y, 0);
        transform.position = positionOfPaddle;
    }



    /*
    private void CameraPositionTracking()
    {
        Vector3 positionOfPaddle = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 ZfixPositionOfPaddle = new Vector3(positionOfPaddle.x, positionOfPaddle.y, 0);
        transform.position = ZfixPositionOfPaddle;
    }
    */
}
