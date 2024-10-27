using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniMap : MonoBehaviour
{
    public Player.Player player;
    public RectTransform rect;

    // Update is called once per frame
    void Update()
    {
        rect.anchoredPosition = new Vector2(player.transform.position.x, player.transform.position.y);
        rect.rotation = Quaternion.Euler(0, 0, player.transform.rotation.y);
    }
}
