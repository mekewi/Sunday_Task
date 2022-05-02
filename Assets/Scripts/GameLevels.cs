using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "GameLevels",fileName = "GameLevels")]
public class GameLevels : ScriptableObject
{
    public List<GameObject> levels = new List<GameObject>();
}
