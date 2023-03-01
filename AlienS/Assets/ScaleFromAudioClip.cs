using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleFromAudioClip : MonoBehaviour
{
    public AudioSource source;
    public Vector3 minScale;
    public Vector3 maxScale;
    public AudioLoudnessDetection detector;

    public float loudnessSensibility = 100;
    public float threshold = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        // Get list of Microphone devices and print the names to the log
        void Start()
        {
            foreach (var device in Microphone.devices)
            {
                Debug.Log("Name: " + device);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        float loudness = detector.GetLoudnessFromMicrophone();
        Debug.Log(loudness * loudnessSensibility);

        //if (loudness * loudnessSensibility < 1)
        //    transform.localScale = Vector3.Lerp(minScale, maxScale, 0.001f * loudnessSensibility);

        //if (loudness * loudnessSensibility > 1 && loudness * loudnessSensibility < 2)
        //    transform.localScale = Vector3.Lerp(minScale, maxScale, 0.003f * loudnessSensibility);

        //if (loudness * loudnessSensibility > 2)
        //    transform.localScale = Vector3.Lerp(minScale, maxScale, 0.005f * loudnessSensibility);

        transform.localScale = Vector3.Lerp(minScale, maxScale, loudness * loudnessSensibility);



    }
}

