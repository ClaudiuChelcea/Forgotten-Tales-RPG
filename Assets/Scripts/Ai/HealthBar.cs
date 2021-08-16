using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;

public class HealthBar : NetworkBehaviour
{
    [SerializeField]
    private Image foregroundImage;
    private Camera myCamera;

    public float FillAmount { get { return foregroundImage.fillAmount; } set { foregroundImage.fillAmount = value; } }

    private void Start()
    {
        myCamera = Camera.main;
    }

    private void LateUpdate()
    {
        if (isServer == false)
        {
            return;
        }
        transform.LookAt(myCamera.transform);
        transform.Rotate(0, 180, 0);
    }
}
