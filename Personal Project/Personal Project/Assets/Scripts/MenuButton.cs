using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuButton : MonoBehaviour
{
    private Button button;

    private GameManager gameManager;

    public int initiateGame;
   
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetGame);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
 
    void SetGame()
    {
        Debug.Log(gameObject.name + "was clicked");
        gameManager.StartGame(initiateGame);
    }
}
