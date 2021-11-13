using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _startGame;
    [SerializeField] private GameObject _aboutAuthors;
    [SerializeField] private GameObject _exitGame;
    [SerializeField] private Button _start;
    [SerializeField] private Button _authors;
    [SerializeField] private Button _exit;

    private void Start()
    {
        _start.onClick.AddListener(StartGame);
        _authors.onClick.AddListener(Authors);
        _exit.onClick.AddListener(Exit);
    }

    private void StartGame()
    {
        _startGame.SetActive(true);
    }

    private void Authors()
    {
        _aboutAuthors.SetActive(true);
    }

    private void Exit()
    {
        _exitGame.SetActive(true);
    }
}
