using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelPrefab : MonoBehaviour
{

    public Text levelNumber;

	void Start () {
	
	}

    public void PlaceNumber(int number)
    {
        levelNumber.text = number.ToString();
    }

}
