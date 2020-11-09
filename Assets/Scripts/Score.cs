using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
  public TextMeshProUGUI scoreUI;
  public GameObject gameOverCanvas;

  private static int currentScore = 0;

  private void Awake()
  {
    currentScore = 0;
  }

  private void Update()
  {
    scoreUI.text = currentScore.ToString("0");
  }

  public void IncreaseScore(int points)
  {
    currentScore += points;
  }

  public void GameOver()
  {
    GameObject.Find("UICanvas").SetActive(false);
    gameOverCanvas.SetActive(true);
    gameOverCanvas.GetComponentInChildren<Button>().Select();
    gameOverCanvas.GetComponentInChildren<TextMeshProUGUI>()
        .SetText(currentScore.ToString("0"));

    // GameObject.Find("GameOverCanvas").GetComponentInChildren<TextMeshProUGUI>( )
    // .SetText(currentScore.ToString( ));
  }

}
