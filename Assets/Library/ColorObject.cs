using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorObject : MonoBehaviour
{
  
    SpriteRenderer sRenderer;
    private void Awake()
    {
        sRenderer = GetComponent<SpriteRenderer>();
    }

    public void SetColor(Player player, bool highlight)
    {
        sRenderer.color = PlayerColors.instance.GetPlayerColor(player, highlight);
    }
}
