using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI.Table;
using UnityEngine.UI;

public class MoveCoin : MonoBehaviour
{
    public float speed = 1f;
    private Vector3 targetPosition;

    
    private float row;
    private int column;
    

    Vector3 PosExampleChip;
    bool isInstantiated = false;
    // public GameObject exampleChip;

    public GameObject Button00;




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









        /*

        if ((isInstantiated) & column == 0)
        {
            InitializeStone(4f,1);

          
        }


        if (isInstantiated = true & column == 1)
        {
            InitializeStone(4f, 0);

            Debug.Log("isInstantiated funktioniert, yeah ! ");
        }

        if (column == 2)
        {
            InitializeStone(3f, 0);
        }

        if (column == 3)
        {
            InitializeStone(2f, 0);
        }

        if (column == 4)
        {
            InitializeStone(1f, 0);
        }

        if (column == 5)
        {
            InitializeStone(5f, 0);
        }

        if (column == 0)
        {
            InitializeStone(5f, 0);
        }

        */


        if (isInstantiated)               //  & column == 0
        {
            InitializeStone(4f, 1);


        }



        if (isInstantiated)
        {
            MoveStone();

            Debug.Log("MoveStone funktioniert");
        }
       

    }

    public void InitializeStone (float row, int column)
    {
        this.row = row;
        this.column = column;

        //row = 5f;
        //column = 5;

        // Vector3 targetPosition = BoardPositions.GetWorldPosition(row, column);

        isInstantiated = true;

        Debug.Log("Stone wurde initialized");
        // Debug.Log("Stone wurde initialisiert");
        // Debug.Log("X: " + exampleChip.transform.position.x + "Y: " + exampleChip.transform.position.y);

        

    }

    public void MoveStone()
    {
        // Vector3 WolrdPosition = BoardPositions.GetWorldPosition(2f, 3);
        // row = 5f;
        // column = 2;

        targetPosition = BoardPositions.GetWorldPosition(row, column);
      

        this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, speed * Time.deltaTime);
        Debug.Log(this.transform.position);

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
