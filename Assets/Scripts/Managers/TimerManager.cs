using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class TimerManager : MonoBehaviour {

	public static float time;
	PlayerHealth playerHealth;
	string minutes;
	string seconds;

    Text text;

    void Awake ()
    {
        text = GetComponent <Text> ();
        time = 0;
		playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }


    void Update ()
    {
		if (playerHealth.IsDead()) {
			return;
		}
		time += Time.deltaTime;
		minutes = Mathf.Floor(time/60).ToString("00");
		seconds = (time % 60).ToString("00");
        text.text = string.Format("{0}:{1}", minutes, seconds);
    }
}
