using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelPrefab : MonoBehaviour
{

    public Text levelNumber;
    private int currentNumber;

	void Start () {
	
	}

    public void PlaceNumber(int number)
    {
        levelNumber.text = number.ToString();
        currentNumber = number;
    }

    public void OnLevelClick()
    {
        LevelStorage.Instance.SetCurrentLevel(currentNumber);
        Debug.Log(currentNumber);
        Application.LoadLevel("Game");
    }

}
