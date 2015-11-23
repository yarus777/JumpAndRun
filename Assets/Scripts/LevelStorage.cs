using UnityEngine;
using System.Collections;

public class LevelStorage : MonoBehaviour
{

    public static LevelStorage Instance;

	void Start () {
	
	}
	

    void Awake()
    {
        Instance = this;
    }


}
