using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/**
 * Class to do a character selection on Unity3D
 * 
 * @author Jefferson Henrique
 * */
public class SelectChar : MonoBehaviour
{
    public GUIContent btnTexture;
    // The left marker out of visible scence
    public Transform markerLeft2;
    // The left marker of visible scence
    public Transform markerLeft;
    // The middle marker of visible scence
    public Transform markerMiddle;
    // The right marker of visible scence
    public Transform markerRight;
    // The right marker out of visible scence
    public Transform markerRight2;

    // The characters prefabs to pick
    public Transform[] charsPrefabs;

    // The game objects created to be showed on screen
    private GameObject[] chars;

    // The index of the current character
    public int currentChar = 0;

    void Start()
    {
        // We initialize the chars array
        chars = new GameObject[charsPrefabs.Length];

        // We create game objects based on characters prefabs
        int index = 0;
        foreach (Transform t in charsPrefabs)
        {
            chars[index++] = GameObject.Instantiate(t.gameObject, markerRight2.position, Quaternion.identity) as GameObject;
        }
    }

    
    }

