using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Confirm01 : MonoBehaviour
{
    private Button button;
    private void Start()
    {
        button = GetComponent<Button>();
    }
    private void Update()
    {
        button.onClick.AddListener(F);
    }
    private void F()
    {
        GameObject.FindObjectOfType<PlayerSelection>().playerType = PlayerType.player01;
    }
}
