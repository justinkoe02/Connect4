using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCoin : MonoBehaviour
{
    public float speed = 10f;
    Vector3 TargetPosition;

    Vector3 PosExampleChip;
    bool isInstantiated = false;
    public GameObject exampleChip;


    // Update is called once per frame
    void Update()
    {
        /*
         
        void MoveStone()
        {
            GameManager gameManager = Examplechip.GetComponent<GameManager>();

            GameManager.

            bool isInstantiated = true;

            if (isInstantiated = true)
            {
                Debug.Log("isInstantiated funktioniert");

                PosExampleChip =
            }
    
        }

        */

        MoveStone();



    }

    void MoveStone()
    {
        // Vector3 WolrdPosition = BoardPositions.GetWorldPosition(2f, 3);
        Vector3 TargetPosition = BoardPositions.GetWorldPosition(2f, 3);

        transform.position = Vector3.Lerp(transform.position, TargetPosition, speed * Time.deltaTime);

        /*
        if (exampleChip != null)
        {
            transform.Translate = (WolrdPosition *speed * Time.deltaTime);
            

           // Debug.Log(transform.position);

           // Debug.Log("chip sollte sich eig bewegen");
        }
        */


    }

}
