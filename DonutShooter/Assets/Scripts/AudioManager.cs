using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {
    public AudioSource audi;
    public AudioClip bgmSound;
    public AudioClip hitSound;
    public AudioClip shootSound;
    public AudioClip getHeartSound;
    public AudioClip dedSound;
    public AudioClip reloadSound;

	// Use this for initialization
	void Start () {
        audi = gameObject.GetComponent<AudioSource>();

	}

    void hit()
    {
        audi.PlayOneShot(hitSound);
    }

    void shoot()
    {
        audi.PlayOneShot(shootSound);
    }
    void getheart()
    {
        audi.PlayOneShot(getHeartSound);
    }
    void ded()
    {
        audi.PlayOneShot(dedSound);
    }
    void reload()
    {
        audi.PlayOneShot(reloadSound);
    }

}
