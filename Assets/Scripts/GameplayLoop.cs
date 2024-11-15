using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayLoop : MonoBehaviour
{

    public bool endGame;

    // Start is called before the first frame update
    void Start()
    {

    }

    IEnumerator GameLoop()
    {
        while (endGame == false)
        {


            yield return null;
        }
    }
}
