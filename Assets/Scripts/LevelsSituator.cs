using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelsSituator : MonoBehaviour
{

    public int levelsCount;
    public Transform levelPrefab;

    private List<Transform> levels = new List<Transform>();

	void Start ()
	{

	    InstantiateLevels();

	}

    private void InstantiateLevels()
    {

        for (int i = 0; i < LevelStorage.Instance.Levels.Count; i++)
        {
            levels.Add((Transform)Instantiate(levelPrefab));
            
        }

        PlaceLevels();
    }

    private void PlaceLevels()
    {
        for (int i = 0; i < LevelStorage.Instance.Levels.Count; i++)
        {
            float prefabHeight = levelPrefab.GetComponent<RectTransform>().sizeDelta.y;
            levels[i].transform.parent = gameObject.transform;
            levels[i].GetComponent<RectTransform>().offsetMax = Vector2.zero;
            levels[i].GetComponent<RectTransform>().offsetMin = Vector2.zero;
            levels[i].GetComponent<RectTransform>().anchoredPosition = new Vector2(0, - i * prefabHeight);
            levels[i].GetComponent<LevelPrefab>().PlaceNumber(LevelStorage.Instance.Levels[i].levelNumber);
        }
    }
}
