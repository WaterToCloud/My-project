using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Changer : MonoBehaviour
{

    [SerializeField] Sprite[] randomImage;
    private Sprite oldImage;
    public Image image;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            oldImage = randomImage[Random.Range(0, randomImage.Length)];
            image.sprite = oldImage;
        }
    }
}