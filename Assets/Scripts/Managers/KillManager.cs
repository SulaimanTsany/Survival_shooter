using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class KillManager : MonoBehaviour
{
    public static int kill;


    Text text;


    void Awake ()
    {
        text = GetComponent <Text> ();
        kill = 0;
    }


    void Update ()
    {
        text.text = "KILL: " + kill;
    }
}
