using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Look02 : MonoBehaviour
{
    private Button button;
    PlayerDescription playerDescription;
    private void Start()
    {
        button = GetComponent<Button>();
        playerDescription = GameObject.FindObjectOfType<PlayerDescription>();
    }
    private void Update()
    {
        button.onClick.AddListener(F);
    }
    private void F()
    {
        PlayerSelection.ShowDescription(PlayerInfo.player02Info);
    }
}
