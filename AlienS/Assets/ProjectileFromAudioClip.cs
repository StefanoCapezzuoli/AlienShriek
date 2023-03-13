using System.Collections;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using UnityEngine;

public class ProjectileFromAudioClip : MonoBehaviour
{
    public Vector3 minScale;
    public Vector3 maxScale;
    public AudioLoudnessDetection detector;

    public float loudnessSensibility = 100;
    public float threshold = 0.1f;
    public float coolDownPeriodInSeconds;


    private float timeStamp;
    private bool cooldown;
    

    // Start is called before the first frame update
    void Start()
    {
        // Get list of Microphone devices and print the names to the log
        void Start()
        {
            
            foreach (var device in Microphone.devices)
            {
                //Debug.Log("Name: " + device);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        float loudness = detector.GetLoudnessFromMicrophone();
        //Debug.Log(loudness * loudnessSensibility);

        //PlayMakerFSM.BroadcastEvent("Max");
        if (cooldown == false)
        {
            timeStamp = Time.time + coolDownPeriodInSeconds;
            if (loudness * loudnessSensibility > 2f && loudness * loudnessSensibility < 3)
            {
                //transform.localScale = new Vector3(1f, 1f, 1f);
                PlayMakerFSM.BroadcastEvent("Min");
                cooldown = true;
            }

            if (loudness * loudnessSensibility > 3 && loudness * loudnessSensibility < 4)
            {
                //transform.localScale = new Vector3(2f, 2f, 2f);
                PlayMakerFSM.BroadcastEvent("Mid");
                cooldown = true;
            }

            if (loudness * loudnessSensibility > 5)
            {
                //transform.localScale = new Vector3(3f, 3f, 3f);
                PlayMakerFSM.BroadcastEvent("Max");
                cooldown = true;
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayMakerFSM.BroadcastEvent("Min");
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                PlayMakerFSM.BroadcastEvent("Mid");
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                PlayMakerFSM.BroadcastEvent("Max");
            }
        }
        else
        {
            if (timeStamp <= Time.time)
            {
                cooldown = false;
            }
        }

        //transform.localScale = Vector3.Lerp(minScale, maxScale, loudness * loudnessSensibility);



    }
}

