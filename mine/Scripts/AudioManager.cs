using UnityEngine.Audio;
using System; 
using UnityEngine;

public class AudioManager : MonoBehaviour {

public Sound[] sounds;

public static AudioManager instance;

void Awake () {

    if (instance == null)
    {
        instance = this;
        }
    else
    {
        Destroy(gameObject);
    return;
    }
        DontDestroyOnLoad(gameObject);

foreach (Sound s in sounds)
{
    s.source = gameObject.AddComponent<AudioSource>();
    s.source.clip = s.clip;

    s.source.volume = s.volume;
    s.source.pitch = s.pitch;

}
}

public void Start ()
{
    Play("TransitoContinuo");
}

public void Stop (string name)
 {
Sound s = Array.Find(sounds, sound => sound.name == name);
  if (s == null)
  {
   Debug.LogWarning("O som: " + name + " não existe.");
   return;
  }
  s.source.Stop();
 }


public void Play (string name)
{
Sound s = Array.Find(sounds, sound => sound.name == name);
if (s == null)
{
    Debug.LogWarning("O som: " + name + " não existe.");
    return; 
}
s.source.Play();
}

public void Update()
{
    Stop("TransitoContinuo");
}

}
