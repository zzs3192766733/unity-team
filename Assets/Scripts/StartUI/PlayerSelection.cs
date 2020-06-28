using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelection : MonoBehaviour
{
    [HideInInspector]
    public PlayerType playerType;
    private GameObject player;
    private PlayerInfo info;
    private static PlayerDescription playerDescription;
    private float widthRatio;
    private float heightRatio;
    private RectTransform rect;
    private void Start()
    {
        playerType = PlayerType.empty;
        player = GameObject.FindWithTag("Player");
        info = GameObject.FindObjectOfType<PlayerInfo>();
        playerDescription = GameObject.FindObjectOfType<PlayerDescription>();
        CloseDescription();
        widthRatio = (float)Screen.width / 1024;
        heightRatio = (float)Screen.height / 768;
        rect = GetComponent<RectTransform>();
        rect.localScale = new Vector2(widthRatio, heightRatio);
    }
    private void Update()
    {
        if(playerType==PlayerType.player01)
        {
            player.AddComponent<Player01>();
            player.GetComponent<Player01>().hitPoint = PlayerInfo.player01HitPoint;
            player.GetComponent<Player01>().damage = PlayerInfo.player01Damage;
            player.GetComponent<Player01>().energy = PlayerInfo.player01Energy;
            Destroy(gameObject);
        }
        if (playerType == PlayerType.player02)
        {
            player.AddComponent<Player02>();
            player.GetComponent<Player02>().hitPoint = PlayerInfo.player02HitPoint;
            player.GetComponent<Player02>().damage = PlayerInfo.player02Damage;
            player.GetComponent<Player02>().energy = PlayerInfo.player02Energy;
            Destroy(gameObject);
        }
        if (playerType == PlayerType.player03)
        {
            player.AddComponent<Player03>();
            player.GetComponent<Player03>().hitPoint = PlayerInfo.player03HitPoint;
            player.GetComponent<Player03>().damage = PlayerInfo.player03Damage;
            player.GetComponent<Player03>().energy = PlayerInfo.player03Energy;
            Destroy(gameObject);
        }
    }
    public static void ShowDescription(string info)
    {
        playerDescription.text.text = info;
        playerDescription.gameObject.SetActive(true);
    }
    public static void CloseDescription()
    {
        playerDescription.gameObject.SetActive(false);
    }
}
