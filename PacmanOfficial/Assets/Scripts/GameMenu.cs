using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public static bool isOnePlayerGame = true;

    public void OnePlayerGame()
    {
        GameBoard.playerOneLevel = 1;
        GameBoard.playerOneScore = 0;
        GameBoard.livesPlayerOne = 3;

        GameBoard.livesPlayerTwo = 0;
        SceneManager.LoadScene(1);
    }

    public void TwoPlayerGame()
    {
        isOnePlayerGame = false;
        GameBoard.playerOneLevel = 1;
        GameBoard.playerOneScore = 0;
        GameBoard.livesPlayerOne = 3;

        GameBoard.playerTwoLevel = 1;
        GameBoard.playerTwoScore = 0;
        GameBoard.livesPlayerTwo = 3;
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene(2);
    }

    public void Returning()
    {
        SceneManager.LoadScene(0);
    }
}