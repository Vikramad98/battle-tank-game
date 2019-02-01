﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "DefaultData", menuName = "ScriptableObj/CreateDefaultData", order = 4)]
public class DefaultScriptableObject : ScriptableObject 
{
    [Scene]
    public string mainScene, gameScene, gameOverScene;
    public int highScore;
	
}
