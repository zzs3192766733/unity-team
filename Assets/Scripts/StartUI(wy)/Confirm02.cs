using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Confirm02 : MonoBehaviour
{
    private Button button;
    private PlayerSelection playerSelection;
    private void Start()
    {
        button = GetComponent<Button>();
        playerSelection = GameObject.FindObjectOfType<PlayerSelection>();
    }
    private void Update()
    {
        button.onClick.AddListener(F);
    }
    private void F()
    {
        playerSelection.playerType = PlayerType.player02;
    }
}
