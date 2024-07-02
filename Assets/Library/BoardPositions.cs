using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BoardPositions 
{
   public static Vector3 GetWorldPosition(float row, int column)
    {
        Debug.Assert(column >= 0 && column <= 6, "Column must be in the range 0..6");
        Debug.Assert(row >= 0 && row <= 5, "Row must be in the range 0..5");

        Vector2 boardPosition = new Vector2(column, 5.0f - row);
        Vector3 wPos = new Vector3(0, 0, 0);
        wPos += new Vector3((boardPosition.x -3) * 1.3f, boardPosition.y * 1.12f, 0);
        return wPos;
    }

    public static Vector3 GetWorldPositionAboveBoard(int column)
    {
        Vector3 wPos = new Vector3(0, 0, 0);
        wPos += new Vector3((column - 3) * 1.3f, 7.2f, 0);
        return wPos;
    }
}
