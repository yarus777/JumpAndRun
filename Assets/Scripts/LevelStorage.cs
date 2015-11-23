using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelStorage : MonoBehaviour
{

    public static LevelStorage Instance;
    private Level[] levels;

	void Start () {
	
	}
	

    void Awake()
    {
        Instance = this;
        levels = Resources.LoadAll<Level>("Levels");
        Debug.Log(levels.Length);

    }

    public IList<Level> Levels
    {
        get
        {
            return levels;
        }
    }

}
