using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelection : MonoBehaviour
{
    [HideInInspector]
    public PlayerType playerType;
    private GameObject player;
    PlayerInfo info;
    private void Start()
    {
        playerType = PlayerType.empty;
        player = GameObject.FindWithTag("Player");
        info = GameObject.FindObjectOfType<PlayerInfo>();
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
}
