using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAgain : MonoBehaviour
{
    public GameObject player;
    public GameObject playerCamera;
    public GameObject selectTool;
    public GameObject selectTool2;
    public void PlayGameAgain()
    {
        player.transform.position = new Vector3(PlayerPrefs.GetFloat("playerposx"), PlayerPrefs.GetFloat("playerposy"), PlayerPrefs.GetFloat("playerposz"));
        playerCamera.transform.position = new Vector3(PlayerPrefs.GetFloat("playerposx"), PlayerPrefs.GetFloat("playerposy"), PlayerPrefs.GetFloat("playerposz"));
        selectTool.SetActive(false);
        selectTool2.SetActive(false);
    }
}
