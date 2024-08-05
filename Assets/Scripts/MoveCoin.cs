using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI.Table;
using UnityEngine.UI;

public class MoveCoin : MonoBehaviour
{
  
    //Vector3 PosExampleChip;
    // bool isInstantiated = false;
    // public GameObject exampleChip;

    // public GameObject Button00;
    //private bool isClicked = false;

    //public GameManager gameManager;
    private float row;
    private int column;
    private float speed;
    private Vector3 targetPosition;

    private bool positionLocked = false;


    public void Initialize(float row, int column, float speed){
        this.speed = speed;
        this.row = row;
        this.column = column;

        if(column == 0){

            this.row = 5f;
            this.column = 0;

            positionLocked = true;
        }   

        if (column == 1)
        {
            this.row = 5f;
            this.column = 1;
        }

        if (column == 2)
        {
            this.row = 5f;
            this.column = 2;
        }

        if (column == 3)
        {
            this.row = 5f;
            this.column = 3;
        }

        if (column == 4)
        {
            this.row = 5f;
            this.column = 4;
        }

        if (column == 5)
        {
            this.row = 5f;
            this.column = 5;
        }

        if (column == 6)
        {
            this.row = 5f;
            this.column = 6;
        }


        targetPosition = BoardPositions.GetWorldPosition(this.row, this.column);

        


        /*
        if (positionLocked)
        {
            // this.row = this.row - 1f * Time.deltaTime;
            targetPosition = BoardPositions.GetWorldPosition(this.row -1, this.column);

            Debug.Log("positionLocked works");
        }
        */


     
    }




    // Update is called once per frame
    void Update()
    {
        /*
        if (this.row == 5)
        {

            positionLocked = true;
            this.row -= 1;
            targetPosition = BoardPositions.GetWorldPosition(this.row, this.column);

            Debug.Log("wupp wupp ");
        }
        */

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);


        //if(transform.position == targetPosition && positionLocked)
        if (Vector3.Distance(transform.position, targetPosition) < 0.01f && positionLocked)
          {

            targetPosition = BoardPositions.GetWorldPosition(this.row -1f, this.column);
            positionLocked = false;


            if (row < 2f)
            {
                
                Debug.Log("positionLocked wieder aus");
            }

            else
            {
                targetPosition = BoardPositions.GetWorldPosition(row, column);

                Debug.Log("neue Position ist: " + targetPosition);
            }

            
          }

        /*
        for (; positionLocked == true; --this.row)
        {

            Debug.Log("positionLocked works");

            
            if (this.row = 0f)
            {
                positionLocked = false;
                Debug.Log("positionLocked wieder aus");
            }
            

            targetPosition = BoardPositions.GetWorldPosition(this.row, this.column);
        }
        /*

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

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

        /*
        if (!isInstantiated & column == 0)              
        {
            InitializeStone(4f, 1);


        }

        if (!isInstantiated & column == 1)
        {
            InitializeStone(2f, 1);


        }



        if (isInstantiated)
        {
            MoveStone();

            Debug.Log("MoveStone funktioniert");
        }
       

    }

    public void InitializeStone (float row, int column)
    {
        // this.row = row;
        // this.column = column;

        isInstantiated = true;

        if((isInstantiated) & column == 0)
        {
            row = 4f;
            column = 4;

            Debug.Log("Stone wurde an 4/4 instantiiert");
        }

        if (isInstantiated & column == 1)
        {
            row = 5f;
            column = 4;
        }


        // Vector3 targetPosition = BoardPositions.GetWorldPosition(row, column);

        isInstantiated = true;

        if (isInstantiated == true)
        {
            Debug.Log("Stone wurde initialized");

        }




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

        // Debug.Log(this.transform.position);






        /*
        if (exampleChip != null)
        {
            transform.Translate = (WolrdPosition *speed * Time.deltaTime);
            

           // Debug.Log(transform.position);

           // Debug.Log("chip sollte sich eig bewegen");
        }
        */


        //moveStone();


    }


  

    /*
    public void moveStone(){


        // gameManager.isInstatiated = true;
        if (gameManager != null){
            gameManager.isInstatiated = true;
        }

        if(gameManager.isInstatiated == true){

            Debug.Log("isClicked works ");
        }

        
        
    }
    */
    



}
